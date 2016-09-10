using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Common;
using CheckAvability.Model;
using Newtonsoft.Json.Linq;
namespace CheckAvability.Service
{
    public class CheckIphoneService : BaseHttpClient, ICheckIphoneService
    {
        private IConfiguration config { get; set; }
        public CheckIphoneService(IConfiguration _Config) : base(_Config)
        {
            this.config = _Config;
        }

        public async Task<object> GetIphoneTaskAsyn()
        {
            dynamic result = await base.GetAsync<object>(config.GetBaseUrl(), config.GetAvailabilityUrl());
            return result;
        }
    }
}
