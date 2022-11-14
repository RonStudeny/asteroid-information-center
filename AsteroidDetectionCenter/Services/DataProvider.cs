using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidDetectionCenter.Services
{
    public class DataProvider
    {
        public static async Task RequestAndCache(string url, HttpClient httpClient)
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            var json = await httpResponseMessage.Content.ReadAsStringAsync();
            File.WriteAllText("CachedData.json", json);
        }
    }
}
