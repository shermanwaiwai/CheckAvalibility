using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAvability.Common
{
    public class Shop
    {
        public static string GetShopName(string name)
        {
            switch (name)
            {
                case ("R409"):
                    return "CWB";
                    break;
                case ("R428"):
                    return "IFC";
                    break;
                case ("R485"):
                    return "FW";
                    break;
                case ("R499"):
                    return "TST";
                    break;
                case ("R610"):
                    return "ShaTin";
                default:
                    return string.Empty;
            }
        }
    }
}
