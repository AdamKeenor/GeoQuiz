using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GeoQuiz 
{
    public class Countries : MonoBehaviour
    {
        List<Country> countries = new List<Country>();

        
        
        
        private void Start()
        {
            countries = GetCountries(countries);
        }

        public List<Country> GetCountries(List<Country> countries)
        {
            List<Country> newCountries = countries;

            Country france = new Country();
            france = france.GetFranceData();

            Country germany = new Country();

            Country mozambique = new Country();


            germany.Name = "Germany";
            germany.ImageLocation = "C:/pics/maps/geoq/germany.jpg";
            germany.Description = "A lovely nation that was on holiday from 1939 to 1945. No questions.";


           
            mozambique.Name = "Mozambique";
            mozambique.ImageLocation = "C:/picsofafrica2k17/myfavplaces/mozambique.jpg";
            mozambique.Description = "I don't really know much about Mozambique.";


            newCountries.Add(germany);
            newCountries.Add(france);
            newCountries.Add(mozambique);

          


            return newCountries;

        }

    }
}
