using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace coolpuppy24.buypermission
{
    public class BuyCommand : IRocketCommand
    {
        public static BuyPermission Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() { "pbuy", "buykit" };
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
                return "Buy a Permission Group";
            }
        }

        public string Name
        {
            get
            {
                return "buypermission";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "buypermission.buy" };
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

        }
    }
}
