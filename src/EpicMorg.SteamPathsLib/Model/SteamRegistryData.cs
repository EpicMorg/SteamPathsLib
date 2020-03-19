namespace EpicMorg.SteamPathsLib.Model
{
    public class SteamRegistryData
    {
        public string RegistryKey { get; set; }

        public string LastGameNameUsed { get; set; }

        public string SourceModInstallPath { get; set; }

        public string SteamExe { get; set; }

        public string SteamPath { get; set; }

        public string Language { get; set; }

        public string PseudoUUID { get; set; }

        public string ModInstallPath { get; set; }

        public int RunningAppID { get; set; }

        public bool AlreadyRetriedOfflineMode { get; set; }

        public bool RememberPassword { get; set; }
    }
}
