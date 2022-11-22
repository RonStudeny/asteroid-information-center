using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AsteroidDetectionCenter.Droid;
using AsteroidDetectionCenter.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace AsteroidDetectionCenter.Droid
{
    public class FileService : IFileService
    {
        public void CreateFile(string input)
        {
            string fileName = "cachedData.txt";
            var destination = Path.Combine(GetRootPath(), fileName);

            File.WriteAllText(destination, input);
        }

        public string GetRootPath()
        {
            return Application.Context.GetExternalFilesDir(null).ToString();
        }


    }
}