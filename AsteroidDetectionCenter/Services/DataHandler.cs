using AsteroidDetectionCenter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AsteroidDetectionCenter.Services
{
    public class DataHandler
    {
        public static Rootobject Data { get; set; }


        public static ObservableCollection<string> AvailablePlanets()
        {
            List<string> res = new List<string>();
            ObservableCollection<string> planets = new ObservableCollection<string>();

            foreach (var asteroids in Data.near_earth_objects)
                foreach (var data in asteroids.close_approach_data)
                    planets.Add(data.orbiting_body);

            return planets;
        }


    }
}
