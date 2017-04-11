using System;
using System.Linq;
using System.Reflection;
using Rocket.API;
using Rocket.Unturned.Player;
using UnityEngine;
using SDG.Unturned;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.API.Collections;
using Rocket.Unturned.Chat;
using Rocket.Core;
using System.Collections.Generic;
using fr34kyn01535.Uconomy;

namespace coolpuppy24.buypermission
{
    public class BuyPermission : RocketPlugin<BuyPermissionConfiguration>
    {
        public static BuyPermission Instance = null;

        public int lastindex = 0;
        public DateTime? lastmessage = null;

        protected override void Load()
        {
            Rocket.Core.Logging.Logger.LogWarning("BuyPermission made by: Coolpuppy24 and xdlewisdx.");
            Rocket.Core.Logging.Logger.LogWarning("Plugin Version: 1.0");
            Rocket.Core.Logging.Logger.LogWarning("Remember! You need Uconomy for this plugin!");
            Rocket.Core.Logging.Logger.Log("Successfully Loaded!");
            Rocket.Core.Logging.Logger.LogWarning("-------------------------------------------------");
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList(){
                    {"command_buypermission_invalid_parameter","Invalid parameter, specify a permission group with /buypermission [name]"},
                    {"command_buypermission_not_found","Permission Group not found"},
                    {"command_buypermission_cooldown_command","You have to wait {0} seconds to use this command again"},
                    {"command_buypermission_success","You are now in the group: {0}" },
                    {"command_perms","These following groups are available for purchase: {0}" },
                    {"command_buypermission_no_money","You can't afford the Permission Group {2}. You need atleast {0} {1}." },
                    {"command_buypermission_cost","This group costs: {3}"},
                };
            }
        }
    }
}
