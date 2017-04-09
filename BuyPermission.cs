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
        public static BuyPermission Instance;

        public int lastindex = 0;
        public DateTime? lastmessage = null;

        protected override void Load()
        {
            Instance = this;
            Rocket.Core.Logging.Logger.LogWarning("BuyPermission made by: Coolpuppy24 and xdlewisdx.");
            Rocket.Core.Logging.Logger.LogWarning("Plugin Version: 1.0");
            if (IsDependencyLoaded("Uconomy"))
            {
                Rocket.Core.Logging.Logger.LogWarning("Dependancy Uconomy is there...");
            }
            else
            {
                Rocket.Core.Logging.Logger.LogWarning("Madatory dependency Uconomy is not present.");
            }
            Rocket.Core.Logging.Logger.Log("Successfully Loaded!");
            Rocket.Core.Logging.Logger.LogWarning("-------------------------------------------------");

            Configuration.Load();
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }
    }
}
