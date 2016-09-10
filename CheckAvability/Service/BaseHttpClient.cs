using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Common;
using System.Net;

namespace CheckAvability.Service
{
    public class BaseHttpClient
    {
        protected IConfiguration Config;

        public BaseHttpClient(IConfiguration _Config)
        {
            Config = _Config;
        }

        /// <summary>
        /// Get Asyn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="BaseUrl"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        protected async System.Threading.Tasks.Task<T> GetAsync<T>(string BaseUrl, string url)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = await client.GetAsync(BaseUrl + url);
                if (response.IsSuccessStatusCode)
                {
                    responseJson = await response.Content.ReadAsStringAsync();
                }
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseJson);
        }

        /// <summary>
        /// Get Asyn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        protected async System.Threading.Tasks.Task<T> GetAsync<T>(string url)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(Config.GetBaseUrl());
                client.DefaultRequestHeaders.Accept.Clear();
                var response = await client.GetAsync(Config.GetBaseUrl() + url);
                if (response.IsSuccessStatusCode)
                {
                    responseJson = await response.Content.ReadAsStringAsync();
                }
            }
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseJson);
        }


        /// <summary>
        /// Get
        /// </summary>
        /// <param name="BaseUrl"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        protected HttpResponseMessage Get(string BaseUrl, string uri)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = client.GetAsync(BaseUrl + uri);

                return response.Result;
            }
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        protected HttpResponseMessage Get(string uri)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(Config.GetBaseUrl());
                client.DefaultRequestHeaders.Accept.Clear();
                var response = client.GetAsync(Config.GetBaseUrl() + uri);
                return response.Result;
            }
        }




        /// <summary>
        /// PostAsync
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async System.Threading.Tasks.Task<string> PostAsync(string BaseUrl, string uri, StringContent data)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new System.Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = await client.PostAsync(BaseUrl + uri, data);
                if (response.IsSuccessStatusCode)
                {
                    responseJson = await response.Content.ReadAsStringAsync();
                }
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<string>(responseJson);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BaseUrl"></param>
        /// <param name="uri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async System.Threading.Tasks.Task<string> PostAsync(string BaseUrl, string uri, FormUrlEncodedContent data)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = await client.PostAsync(BaseUrl + uri, data);
                if (response.IsSuccessStatusCode)
                {
                    responseJson = await response.Content.ReadAsStringAsync();
                }
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<string>(responseJson);
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected HttpResponseMessage Post(string BaseUrl, string uri, StringContent data)
        {
            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = client.PostAsync(BaseUrl + uri, data);
                return response.Result;
            }
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="BaseUrl"></param>
        /// <param name="uri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        protected HttpResponseMessage Post(string BaseUrl, string uri, FormUrlEncodedContent content)
        {

            string responseJson = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = client.PostAsync(BaseUrl + uri, content);
                return response.Result;
            }
        }

        //protected HttpResponseMessage GetWithCookes(string BaseUrl, string uri , FormUrlEncodedContent content  , List<Cookie> cookies )
        protected HttpResponseMessage GetWithCookes(string BaseUrl, string uri, List<Cookie> cookies)
        {
            var baseAddress = new Uri(BaseUrl);
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler()
            {
                CookieContainer = cookieContainer
            })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                foreach (var cookie in cookies)
                {
                    cookieContainer.Add(baseAddress, new Cookie(cookie.Name, cookie.Value));
                }
                //var result = client.GetAsync(BaseUrl, content).Result;
                var result = client.GetAsync(uri);
                return result.Result;
                //result.EnsureSuccessStatusCode();
            }
        }
    }
}
