using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAvability.Common
{
    public class Configuration : IConfiguration
    {
        private string baseUrl { get; set; } = "https://reserve-hk.apple.com/HK/en_HK/";
        //private string storesUrl { get; set; } = "https://reserve-hk.apple.com/HK/en_HK/reserve/iPhone/stores.json";
        //private string availabilityUrl { get; set; } = "https://reserve-hk.apple.com/HK/en_HK/reserve/iPhone/availability.json";
        private string storesUrl { get; set; } = "reserve/iPhone/stores.json";
        private string availabilityUrl { get; set; } = "reserve/iPhone/availability.json";

        private string LoginBaseUrl { get; set; } = "https://appleid.apple.com/";
        private string LoginUrl { get; set; } = "#!&page=signin";


        private string LoginPostBaseUrl { get; set; } = "https://idmsa.apple.com/";
        private string LoginPostUrl { get; set; } = "appleauth/auth/signin";



        public Configuration()
        {

        }

        public string GetLoginPostBaseUrl()
        {
            return this.LoginPostBaseUrl;
        }

        public string GetLoginPostUrl()
        {
            return this.LoginPostUrl;
        }

        public string GetLoginBaseUrl()
        {
            return LoginBaseUrl;
        }

        public string GetLoginUrl()
        {
            return LoginUrl;
        }

        public string GetBaseUrl()
        {
            return baseUrl;
        }

        public string GetStoreUrl ()
        {
            //return string.Format("{0}{1}", baseUrl, storesUrl);
            return storesUrl;
        }

        public string GetAvailabilityUrl()
        {
            //return string.Format("{0}{1}", baseUrl, availabilityUrl);
            return availabilityUrl;
        }
    }
}
