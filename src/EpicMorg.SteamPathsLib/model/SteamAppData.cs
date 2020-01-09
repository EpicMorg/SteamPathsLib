﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicMorg.SteamPathsLib.model
{
    public class SteamAppData
    {
        public string RegistryKey;
        public string Name;

        public int AppId;

        public bool Installed;
        public bool Runnig;
        public bool Updating;
    }
}