using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicMorg.SteamPathsLib.model
{
    public class SteamData
    {
        public string RegistryKey;
        public string LastGameNameUsed;
        public string SourceModInstallPath;
        public string SteamExe;
        public string SteamPath;
        public string Language;
        public string PseudoUUID;
        public string ModInstallPath;

        public int RunningAppID;

        public bool AlreadyRetriedOfflineMode;
        public bool RememberPassword;

    }
}
