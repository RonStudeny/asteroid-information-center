using AsteroidDetectionCenter.View_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsteroidDetectionCenter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanetPage : ContentPage
    {
        public PlanetPage(string planet)
        {
            InitializeComponent();
            BindingContext = new PlanetPageVM(planet);
        }
    }
}