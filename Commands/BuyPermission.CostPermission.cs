using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;

namespace coolpuppy24.buypermission
{
    public class CostCommand : IRocketCommand
    {
        public static BuyPermission Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() { "costkit" };
            }
        }

        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }

        public string Help
        {
            get
            {
                return "Check to see how much a permission group costs.";
            }
        }

        public string Name
        {
            get
            {
                return "costpermission";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "buypermission.cost" };
            }
        }

        public string Syntax
        {
            get
            {
                return "<permission group id>";
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            if (command.Length == 0)
            {
                UnturnedChat.Say(player, "Invalid Parimeter");
                return;
            }

            foreach (BuyPermissionConfiguration PermsGroupID in BuyPermission.Instance.Configuration.Instance.BuyPermissionEnd)
            {
                UnturnedChat.Say(player, BuyPermission.Instance.Translations.Instance.Translate("command_buypermission_cost"));
            }           
        }
    }
}
