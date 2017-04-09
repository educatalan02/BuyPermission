using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace coolpuppy24.buypermission
{
    public class CostCommand : IRocketCommand
    {
        public static BuyPermission Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() { "permissioncost", "costpermission" };
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
            UnturnedChat.Say("The Cost of the ", Instance.Configuration.Instance.PermsGroupID, "Group, is", Instance.Configuration.Instance.UconomyCost, ".");
        }
    }
}
