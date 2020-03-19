namespace EpicMorg.SteamPathsLib
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using EpicMorg.SteamPathsLib.Model;
    using Gameloop.Vdf;
    using Gameloop.Vdf.Linq;
    using Microsoft.Win32;

    public static class SteamPathsUtil
    {
        private const string ValveKey = @"Software\Valve";
        private const string ValveSteamKey = @"Software\Valve\Steam";
        private const string ValveSteamAppsKey = @"Software\Valve\Steam\Apps";
        private const string ValveActiveProcessPID = @"Software\Valve\Steam\ActiveProcess";

        private const string ValveSteamAppsPattern = @"Software\Valve\Steam\Apps\";

        public static string GetValveKeyRegistry() => TryOrDefault(() => Registry.CurrentUser.OpenSubKey(ValveKey).ToString());

        public static string GetSteamAppsKeyRegistry() => TryOrDefault(() => Registry.CurrentUser.OpenSubKey(ValveSteamAppsKey).ToString());

        public static ActiveProcessSteamRegistryData GetActiveProcessSteamData() => TryOrDefault(() =>
         {
             using (var regData = Registry.CurrentUser.OpenSubKey(ValveActiveProcessPID))
             {
                 return new ActiveProcessSteamRegistryData
                 {
                     RegistryKey = regData.ToString(),
                     PID = Convert.ToInt32(regData.GetValue("pid") ?? 0),
                 };
             }
         });

        public static SteamAppRegistryData GetSteamAppDataById(int appId) => TryOrDefault(() =>
        {
            using (var regData = Registry.CurrentUser.OpenSubKey(ValveSteamAppsPattern + appId))
            {
                return new SteamAppRegistryData
                {
                    RegistryKey = regData.ToString(),
                    Name = (regData.GetValue("Name") ?? string.Empty).ToString(),

                    AppId = appId,

                    Installed = (regData.GetValue("Installed") ?? 0).Equals(1),
                    Updating = (regData.GetValue("Updating") ?? 0).Equals(1),
                    Running = (regData.GetValue("Running") ?? 0).Equals(1),
                };
            }
        });

        public static SteamRegistryData GetSteamData() => TryOrDefault(() =>
        {
            using (var regData = Registry.CurrentUser.OpenSubKey(ValveSteamKey))
            {
                return new SteamRegistryData
                {
                    RegistryKey = regData.ToString(),
                    LastGameNameUsed = (regData.GetValue("LastGameNameUsed") ?? string.Empty).ToString(),
                    SourceModInstallPath = (regData.GetValue("SourceModInstallPath") ?? string.Empty).ToString(),
                    SteamExe = (regData.GetValue("SteamExe") ?? string.Empty).ToString(),
                    SteamPath = (regData.GetValue("SteamPath") ?? string.Empty).ToString(),
                    Language = (regData.GetValue("Language") ?? string.Empty).ToString(),
                    PseudoUUID = (regData.GetValue("PseudoUUID") ?? string.Empty).ToString(),
                    ModInstallPath = (regData.GetValue("ModInstallPath") ?? string.Empty).ToString(),

                    RunningAppID = Convert.ToInt32((regData.GetValue("RunningAppID") ?? "0").ToString()),

                    RememberPassword = (regData.GetValue("RememberPassword") ?? 0).Equals(1),
                    AlreadyRetriedOfflineMode = (regData.GetValue("AlreadyRetriedOfflineMode") ?? 0).Equals(1),
                };
            }
        });

        public static ConfigSteamData GetSteamConfig() => TryOrDefault(() =>
        {
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
        });

        public static List<LibrarySteamData> GetLibrarySteamDataList() => TryOrDefault(() =>
        {
            var configData = GetSteamConfig();
            var result = new List<LibrarySteamData>();

            foreach (var path in configData.SteamLibraryFolders)
            {
                var libraryData = new LibrarySteamData
                {
                    Path = path,
                    AppManifestDataList = new List<SteamAppManifestData>(),
                };

                var files = new DirectoryInfo(path).GetFiles("appmanifest_*.acf");

                foreach (var file in files)
                {
                    try
                    {
                        var appData = new SteamAppManifestData();
                        dynamic appManifestObject = VdfConvert.Deserialize(File.ReadAllText(file.FullName)).Value;

                        appData.AppId = Convert.ToInt32(appManifestObject.appid.Value);
                        appData.Name = appManifestObject.name.Value;
                        appData.InstallDir = appManifestObject.installdir.Value;

                        appData.Path = Path.Combine(path, "common", appData.InstallDir);

                        libraryData.AppManifestDataList.Add(appData);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                result.Add(libraryData);
            }

            return result;
        });

        public static List<SteamAppManifestData> GetAllSteamAppManifestData() => TryOrDefault(() =>
        {
            var result = new List<SteamAppManifestData>();

            var libraries = GetLibrarySteamDataList();

            foreach (var library in libraries)
            {
                result.AddRange(library.AppManifestDataList);
            }

            return result;
        });

        public static SteamAppManifestData GetSteamAppManifestDataById(int appId) => GetAllSteamAppManifestData()?.FirstOrDefault(appData => appData.AppId == appId);

        private static T TryOrDefault<T>(Func<T> action)
        {
            try
            {
                return action();
            }
            catch
            {
                return default;
            }
        }
    }
}
