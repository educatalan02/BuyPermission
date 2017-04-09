using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace coolpuppy24.buypermission
{
    public class Command : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "buypermission"; }
        }

        public string Help
        {
            get { return "Buy a Permission Group for yourself"; }
        }

        public string Syntax
        {
            get { return "<permission group id"; }
        }

        public List<string> Aliases
        {
            get
            {
                return new List<string>() { "pbuy"};
            }
        }
        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "BuyPermission.buy"
                };

            }
        }
    }
}
