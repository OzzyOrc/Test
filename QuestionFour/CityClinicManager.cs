using QuestionFour.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    public class CityClinicManager
    {
        public CityClinicManager()
        {

        }

        /// <summary>
        /// Purpose of this method is to obtain valid 
        /// user data for number of cities with associated
        /// population and maximum number of clinics
        /// </summary>
        public void UserInputNumberOfCities()
        {
            // Number of cities 
            Console.WriteLine("Enter the number of cities: ");
            string inputNumberOfCities = Console.ReadLine();
            int numberOfCities;
            bool isNumberOfCitiesValid = int.TryParse(inputNumberOfCities, out numberOfCities);

            if (isNumberOfCitiesValid)
            {
                // Build each city and map to a population
                CityManager cityManager = BuildPopulationOfCities(numberOfCities);

                // Number of max clinics
                int numberOfClinics = UserInputNumberOfClinics();

                // Now for the heavy lifting
                var maxPopulationPerClinic = DistributeClinicsOverCities(cityManager, numberOfClinics);

                Console.WriteLine("The maximum number of people each immunization clinic can hold is: " + maxPopulationPerClinic);
            }
            else
            {
                Console.WriteLine("Number of cities must be an integer only!");
            }       
        }

        private int UserInputNumberOfClinics()
        {
            Console.WriteLine("Enter the number of clinics: ");
            string inputNumberOfClinics = Console.ReadLine();
            int numberOfClinics;
            bool isNumberOfClinicsValid = int.TryParse(inputNumberOfClinics, out numberOfClinics);

            if (isNumberOfClinicsValid)
            {
                return numberOfClinics;
            }
            else
            {
                Console.WriteLine("Number of clinics must be an integer only!");
                return 0;
            }
        }

        private CityManager BuildPopulationOfCities(int cities)
        {
            CityManager cityManager = new CityManager();
            for (int i = 1; i <= cities; i++)
            {
                string inputPopulation = Console.ReadLine();
                int populationPerCity;
                int.TryParse(inputPopulation, out populationPerCity);
                City.City city = new City.City(populationPerCity);
                cityManager.Add(city);
            }

            return cityManager;
        }

        public int DistributeClinicsOverCities(CityManager totalCities, int maxClinics)
        {
            var totalPopulaion = totalCities.Cities.Sum(city => city.Population);
            var maxPopulationPerClinic = totalPopulaion / maxClinics;
            return maxPopulationPerClinic;
       }
    }
}
