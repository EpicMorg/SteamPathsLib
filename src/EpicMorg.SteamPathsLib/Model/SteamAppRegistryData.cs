namespace EpicMorg.SteamPathsLib.Model
{
    public class SteamAppRegistryData
    {
        public bool Installed { get; set; }

        public bool Running { get; set; }

        public bool Updating { get; set; }

        public int AppId { get; set; }

        public string Name { get; set; }

        public string RegistryKey { get; set; }
    }
}
