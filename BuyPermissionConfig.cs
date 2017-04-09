using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace coolpuppy24.buypermission
{
    public sealed class Command
    {
        public string PermsGroupID;
        public string Cost;
    }

    public class BuyPermissionConfiguration : IRocketPluginConfiguration
    {

        [XmlArrayItem("BuyPerms")]
        [XmlArray(ElementName = "BuyPermission")]
        public List<Command> BuyPermissionCommand;

        public void LoadDefaults()
        {
            BuyPermissionCommand = new List<Command>(){
                new Command(){PermsGroupID="SniperKit",Cost="100"
                },
                new Command(){PermsGroupID="VIP",Cost="500000"
                },
            };
        }
    }
}
