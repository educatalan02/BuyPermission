using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using SDG.Unturned;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Core;
using System.Collections.Generic;

namespace coolpuppy24.buypermission
{
    public class BuyPermission : RocketPlugin<BuyPermissionConfiguration>
    {
        public int lastindex = 0;
        public DateTime? lastmessage = null;

        protected override void Load()
        {
            Rocket.Core.Logging.Logger.LogWarning("BuyPermission made by: Coolpuppy24 and xdlewisdx.");
            Rocket.Core.Logging.Logger.LogWarning("Plugin Version: 1.0");
            Rocket.Core.Logging.Logger.Log("BuyPermission Successfully Loaded!");
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }
    }
}
