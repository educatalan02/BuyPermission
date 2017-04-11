using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace coolpuppy24.buypermission
{
    public class BuyPermissionConfiguration : IRocketPluginConfiguration
    {
        public string PermsGroupID;
        public int UconomyCost;

        public static BuyPermissionConfiguration Instance = null;

        [XmlArrayItem("BuyPerms")]
        [XmlArray(ElementName = "BuyPermission")]
        public List<BuyPermissionConfiguration> BuyPermissionEnd;

        public object BuyPermissionConfig { get; internal set; }
        public object Configuration { get; internal set; }

        public void LoadDefaults()
        {
            BuyPermissionEnd = new List<BuyPermissionConfiguration>(){
                new BuyPermissionConfiguration(){PermsGroupID="SniperKit",UconomyCost= 100
                },
                new BuyPermissionConfiguration(){PermsGroupID="VIP",UconomyCost= 500000
                },
            };
        }
    }
}
