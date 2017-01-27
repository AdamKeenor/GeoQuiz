using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO;



namespace GeoQuiz
{
    public class Country
    {
        public string Name;
        public string ImageLocation;

        public string Description = "";
        //public List<City> cities = new List<City>();        

        public Country()
        {
            Name = "i'm a country";
        }


        public Country GetFranceData()
        {
            Country france = new Country();

            france.Name = "France";
            france.ImageLocation = "C:/pics/maps/geoq/france.jpg";
            france.Description = "A beautiful country. Full stop.";

            return france;
        }
    }
}
