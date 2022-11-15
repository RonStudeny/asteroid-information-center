using AsteroidDetectionCenter.Models;
using Newtonsoft.Json;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //try
       //     {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                httpResponseMessage.EnsureSuccessStatusCode();
                var json = await httpResponseMessage.Content.ReadAsStringAsync();

                IFolder rootFolder = FileSystem.Current.LocalStorage;
                IFolder folder = await rootFolder.CreateFolderAsync("Cache", CreationCollisionOption.OpenIfExists);
                IFile file = await folder.CreateFileAsync("CachedData.json", CreationCollisionOption.ReplaceExisting);
                await file.WriteAllTextAsync(json);
                
           // }
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //    // inform the user that the data has failed to refresh
            //}

        }


        public static async Task<Rootobject> DeserializeData(string path = @"Cache/CachedData.json")
        {
            IFile file = await FileSystem.Current.GetFileFromPathAsync(path);
            var json = await file.ReadAllTextAsync();
            Rootobject data = JsonConvert.DeserializeObject<Rootobject>(json);

            return data;
        }
    }
}
