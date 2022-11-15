using AsteroidDetectionCenter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidDetectionCenter.Services
{
    public class DataHandler
    {
        public static Rootobject Data { get; set; }


        public static HashSet<string> AvailablePlanets()
        {
            List<string> res = new List<string>();
            HashSet<string> planets = new HashSet<string>();

            foreach (var asteroids in Data.near_earth_objects)
                foreach (var data in asteroids.close_approach_data)
                    planets.Add(data.orbiting_body);

            return planets;
        }


    }
}
