//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using CheckAvability.Common;
//using CheckAvability.Model;
//namespace CheckAvability.Service
//{
//    public class StoreService : BaseHttpClient, IStoreService
//    {
//        private IConfiguration config { get; set; }
//        public StoreService(IConfiguration _Config) : base(_Config)
//        {
//            this.config = _Config;
//        }

//        public async Task<Stores> GetStoreTaskAsyn()
//        {
//            var response = await base.GetAsync<Stores>(config.GetBaseUrl(), config.GetStoreUrl());
//            return response;
//        }


//    }
//}
