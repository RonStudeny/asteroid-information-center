using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidDetectionCenter.View_models
{
    public class PlanetPageVM
    {
        string Title { get; set; }
        public PlanetPageVM(string planet)
        {
            Title = planet;
        }
    }
}
