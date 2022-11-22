using AsteroidDetectionCenter.Services;
using AsteroidDetectionCenter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AsteroidDetectionCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExitButton_Clicked(object sender, EventArgs e) => DependencyService.Get<IFileService>().CreateFile("KYS");


        private void PlanetListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PlanetPage(PlanetListView.SelectedItem as string), true);
        }

        public async Task UpdateData()
        {
            await DataProvider.RequestAndCache("https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=L9vfqrahov8zQo4YayXOF8mhV3dvpqv5OQlth1Vv", new HttpClient());
            DataHandler.Data = await DataProvider.DeserializeData();
            PlanetListView.ItemsSource = DataHandler.AvailablePlanets();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await UpdateData();
        }
    }
}
