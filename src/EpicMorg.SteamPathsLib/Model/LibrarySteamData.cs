namespace EpicMorg.SteamPathsLib.Model
{
    using System.Collections.Generic;

    public class LibrarySteamData
    {
        public List<SteamAppManifestData> AppManifestDataList { get; set; }

        public string Path { get; set; }
    }
}
