using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Model;
using CheckAvability.Common;
using System.Net.Http;

namespace CheckAvability.Service
{
    public class AuthService : BaseHttpClient, IAuthService
    {

        private IConfiguration config { get; set; }
        public AuthService(IConfiguration _Config) : base(_Config)
        {
            this.config = _Config;
        }

        public async Task GetLoginUrlTask()
        {
            var result = base.Get(this.config.GetLoginBaseUrl(), this.config.GetLoginUrl());

            if (result.IsSuccessStatusCode)
            {
                var header = result.Headers;
                var content1 = result.Content;
                var version = result.Version;
            }

            var content = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("accountName", "test"),
                new KeyValuePair<string, string>("password", "test"),
                new KeyValuePair<string, string>("rememberMe", "test")
            });

            var testresult = await base.PostAsync(this.config.GetLoginPostBaseUrl(), this.config.GetLoginPostUrl(), content);
        }
    }
}
