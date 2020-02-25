using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using EpicMorg.SteamPathsLib.Model;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Microsoft.Win32;

namespace EpicMorg.SteamPathsLib {
    public class SteamPathsUtil {
        private static readonly string _valveKey = @"Software\Valve";
        private static readonly string _valveSteamKey = @"Software\Valve\Steam";
        private static readonly string _valveSteamAppsKey = @"Software\Valve\Steam\Apps";
        private static readonly string _valveActiveProcessPID = @"Software\Valve\Steam\ActiveProcess";

        private static readonly string _valveSteamAppsPattern = @"Software\Valve\Steam\Apps\";

        public static string GetValveKeyRegistry() {
            try {
                return Registry.CurrentUser.OpenSubKey(_valveKey).ToString();
            } catch (Exception) {
                return null;
            };
        }

        public static string GetSteamAppsKeyRegistry() {
            try {
                return Registry.CurrentUser.OpenSubKey(_valveSteamAppsKey).ToString();
            } catch (Exception) {
                return null;
            };
        }

        public static ActiveProcessSteamRegistryData GetActiveProcessSteamData() {
            try {
                var regData = Registry.CurrentUser.OpenSubKey(_valveActiveProcessPID);

                var result = new ActiveProcessSteamRegistryData();

                result.RegistryKey = regData.ToString();
                result.PID = Convert.ToInt32((regData.GetValue("pid") ?? 0));

                return result;
            } catch (Exception) {
                return null;
            }
        }

        public static SteamAppRegistryData GetSteamAppDataById(int appId) {
            var appKey = _valveSteamAppsPattern + appId;

            try {
                var regData = Registry.CurrentUser.OpenSubKey(appKey);

                var result = new SteamAppRegistryData();

                result.RegistryKey = regData.ToString();
                result.Name = (regData.GetValue("Name") ?? "").ToString();

                result.AppId = appId;

                result.Installed = (regData.GetValue("Installed") ?? 0).Equals(1);
                result.Updating = (regData.GetValue("Updating") ?? 0).Equals(1);
                result.Runnig = (regData.GetValue("Running") ?? 0).Equals(1);

                return result;
            } catch (Exception) {
                return null;
            }
        }

        public static SteamRegistryData GetSteamData() {
            try {
                var regData = Registry.CurrentUser.OpenSubKey(_valveSteamKey);

                var result = new SteamRegistryData();

                result.RegistryKey = regData.ToString();
                result.LastGameNameUsed = (regData.GetValue("LastGameNameUsed") ?? "").ToString();
                result.SourceModInstallPath = (regData.GetValue("SourceModInstallPath") ?? "").ToString();
                result.SteamExe = (regData.GetValue("SteamExe") ?? "").ToString();
                result.SteamPath = (regData.GetValue("SteamPath") ?? "").ToString();
                result.Language = (regData.GetValue("Language") ?? "").ToString();
                result.PseudoUUID = (regData.GetValue("PseudoUUID") ?? "").ToString();
                result.ModInstallPath = (regData.GetValue("ModInstallPath") ?? "").ToString();

                result.RunningAppID = Convert.ToInt32((regData.GetValue("RunningAppID") ?? "0").ToString());

                result.RememberPassword = (regData.GetValue("RememberPassword") ?? 0).Equals(1);
                result.AlreadyRetriedOfflineMode = (regData.GetValue("AlreadyRetriedOfflineMode") ?? 0).Equals(1);

                return result;
            } catch (Exception) {
                return null;
            }
        }
        public static ConfigSteamData GetSteamConfig() {
            try {
                var result = new ConfigSteamData();
                var libraryPaths = new List<string>();

                var steamPath = new DirectoryInfo(GetSteamData().SteamPath).FullName;
                var configPath = Path.Combine(steamPath, "config", "config.vdf");

                libraryPaths.Add(Path.Combine(steamPath, "steamapps"));

                dynamic configObject = VdfConvert.Deserialize(File.ReadAllText(configPath)).Value;
                var configLibraryPaths = ((VObject)configObject.Software.Valve.Steam)
                    .Children()
                    .Where(item => item.Key.StartsWith("BaseInstallFolder"))
                    .Select(item => item.Value.ToString())
                    .Select(line => new DirectoryInfo(line).FullName)
                    .Select(line => Path.Combine(line, "steamapps"));

                libraryPaths.AddRange(configLibraryPaths);

                result.SteamLibraryFolders = libraryPaths.ToArray();

                return result;
            } catch (Exception) {
                return null;
            }
        }

        public static List<LibrarySteamData> GetLibrarySteamDataList() {
            try {
                var configData = GetSteamConfig();
                var result = new List<LibrarySteamData>();

                foreach (var path in configData.SteamLibraryFolders) {
                    var libraryData = new LibrarySteamData();
                    libraryData.Path = path;
                    libraryData.AppManifestDataList = new List<SteamAppManifestData>();

                    var files = new DirectoryInfo(path).GetFiles("appmanifest_*.acf");

                    foreach (var file in files) {
                        try {
                            var appData = new SteamAppManifestData();
                            dynamic appManifestObject = VdfConvert.Deserialize(File.ReadAllText(file.FullName)).Value;

                            appData.AppId = Convert.ToInt32(appManifestObject.appid.Value);
                            appData.Name = appManifestObject.name.Value;
                            appData.InstallDir = appManifestObject.installdir.Value;

                            appData.Path = Path.Combine(path, "common", appData.InstallDir);

                            libraryData.AppManifestDataList.Add(appData);
                        } catch (Exception e) {
                            Console.WriteLine(e);
                        }
                    }

                    result.Add(libraryData);
                }

                return result;
            } catch (Exception e) {
                Console.WriteLine(e);

                return null;
            }
        }

        public static List<SteamAppManifestData> GetAllSteamAppManifestData() {
            try {
                var result = new List<SteamAppManifestData>();

                var libraries = GetLibrarySteamDataList();

                foreach (var library in libraries) {
                    result.AddRange(library.AppManifestDataList);
                }

                return result;
            } catch (Exception) {
                return null;
            }
        }

        public static SteamAppManifestData GetSteamAppManifestDataById(int appId) => GetAllSteamAppManifestData()?.FirstOrDefault(appData => appData.AppId == appId);
    }
}
