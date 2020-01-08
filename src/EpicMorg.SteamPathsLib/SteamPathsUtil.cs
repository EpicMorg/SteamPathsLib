using System;
using System.Collections.Generic;
using EpicMorg.SteamPathsLib.model;
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

        public static ActiveProcessSteamData GetActiveProcessSteamData()
        {
            try
            {
                var regData = Registry.CurrentUser.OpenSubKey(_valveActiveProcessPID);

                var result = new ActiveProcessSteamData();

                result.RegistryKey = regData.ToString();
                result.PID = Convert.ToInt32((regData.GetValue("pid") ?? 0));

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static SteamAppData GetSteamAppDataById(int appId)
        {
            var appKey = _valveSteamAppsPattern + appId;

            try
            {
                var regData = Registry.CurrentUser.OpenSubKey(appKey);

                var result = new SteamAppData();

                result.RegistryKey = regData.ToString();
                result.Name = (regData.GetValue("Name") ?? "").ToString();

                result.AppId = appId;

                result.Installed = (regData.GetValue("Installed") ?? 0).Equals(1);
                result.Updating = (regData.GetValue("Updating") ?? 0).Equals(1);
                result.Runnig = (regData.GetValue("Running") ?? 0).Equals(1);

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static SteamData GetSteamData()
        {
            try
            {
                var regData = Registry.CurrentUser.OpenSubKey(_valveSteamKey);

                var result = new SteamData();

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
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
