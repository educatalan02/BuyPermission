using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace coolpuppy24.buypermission
{

    public sealed class Config
    {
        public string PermsGroupID;
        public string UconomyCost;
    }

    public class BuyPermissionConfiguration : IRocketPluginConfiguration
    {

        [XmlArrayItem("BuyPerms")]
        [XmlArray(ElementName = "BuyPermission")]
        public List<Config> Perms;

        public void LoadDefaults()
        {
            Perms = new List<Config>(){
                new Config(){PermsGroupID="SniperKit",UconomyCost="100"
                },
                new Config(){PermsGroupID="VIP",UconomyCost="500000"
                },
            };
        }
    }
}
