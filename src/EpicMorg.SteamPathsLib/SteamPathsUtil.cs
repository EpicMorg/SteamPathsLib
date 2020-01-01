using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace EpicMorg.SteamPathsLib
{
    public class SteamPathsUtil
    {
        private static readonly string _valveKey = @"Software\Valve";
        private static readonly string _valveSteamKey = @"Software\Valve\Steam";
        private static readonly string _valveSteamAppsKey = @"Software\Valve\Steam\Apps";
        private static readonly string _valveActiveProcessPID = @"Software\Valve\Steam\ActiveProcess";

        private static readonly string _valveSteamAppsPattern = @"Software\Valve\Steam\Apps\";

        public static Dictionary<string, string> GetInfo()
        {
            var result = new Dictionary<string, string>();

            result["ValveKeyRegistry"] = GetValveKeyRegistry();
            result["SteamKeyRegistry"] = GetSteamKeyRegistry();
            result["SteamAppsKeyRegistry"] = GetSteamAppsKeyRegistry();
            result["SteamDirectoryPath"] = GetSteamDirectoryPath();
            result["SteamExePath"] = GetSteamExePath();
            result["SteamExePid"] = GetSteamExePid();
            result["OriginalSourceModDirectoryPath"] = GetOriginalSourceModDirectoryPath();

            return result;
        }

        public static string GetValveKeyRegistry()
        {
            try
            {
                return Registry.CurrentUser.OpenSubKey(_valveKey).ToString();
            }
            catch (Exception)
            {
                return null;
            };
        }

        public static string GetSteamKeyRegistry()
        {
            try
            {
                return Registry.CurrentUser.OpenSubKey(_valveSteamKey).ToString();
            }
            catch (Exception)
            {
                return null;
            };
        }

        public static string GetSteamAppsKeyRegistry()
        {
            try
            {
                return Registry.CurrentUser.OpenSubKey(_valveSteamAppsKey).ToString();
            }
            catch (Exception)
            {
                return null;
            };
        }

        public static string GetSteamDirectoryPath()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(_valveSteamKey))
                {
                    var path = key.GetValue("SteamPath").ToString();
                    if (path != @"")
                    {
                        return path;
                    }
                }
            }
            catch (Exception) { };

            return null;
        }

        public static string GetSteamExePath()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(_valveSteamKey))
                {
                    var path = key.GetValue("SteamExe").ToString();
                    if (path != @"")
                    {
                        return path;
                    }
                }
            }
            catch (Exception) { };

            return null;
        }

        public static string GetSteamExePid()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(_valveActiveProcessPID))
                {
                    var pid = key.GetValue("pid").ToString();
                    if (pid != @"0")
                    {
                        return pid;
                    }
                }
            }
            catch (Exception) { };

            return null;
        }

        public static string GetOriginalSourceModDirectoryPath()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(_valveSteamKey))
                {
                    var path = key.GetValue("SourceModInstallPath").ToString();
                    if (path != @"")
                    {
                        return path;
                    }
                }
            }
            catch (Exception) { };

            return null;
        }

        public static bool IsInstalledApps(int number)
        {
            try
            {
                var appKey = _valveSteamAppsPattern + number;

                using (var key = Registry.CurrentUser.OpenSubKey(appKey))
                {
                    var installedValue = key.GetValue("Installed");
                    if (installedValue.Equals(1))
                    {
                        return true;
                    }
                }
            }
            catch (Exception) { };

            return false;
        }
    }
}
