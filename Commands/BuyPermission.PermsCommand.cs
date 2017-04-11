using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace coolpuppy24.buypermission
{
    public class PermsCommand : IRocketCommand
    {
        public static BuyPermission Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() {  "buyablekits" };
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
                return "Checks to see what permission groups are available to buy!";
            }
        }

        public string Name
        {
            get
            {
                return "availablepermissions";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "buypermission.perms" };
            }
        }
        public string Syntax
        {
            get
            {
                return "";
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            List<string> availablePerms = new List<string>();

            foreach (BuyPermissionConfiguration PermsGroupID in BuyPermission.Instance.Configuration.Instance.BuyPermissionEnd)
            {
                UnturnedChat.Say(caller, BuyPermission.Instance.Translations.Instance.Translate("command_perms", String.Join(", ", availablePerms.ToArray())));
            } 
        }
    }
}
