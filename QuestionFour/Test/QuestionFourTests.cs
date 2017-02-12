using NUnit.Framework;
using QuestionFour.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour.Test
{
    [TestFixture]
    public class QuestionFourTests
    {
        [Test]
        public void CreateCityTest()
        {
            City.City city = new City.City(500000);

            Assert.IsNotNull(city);
            Assert.AreEqual(city.Population, 500000, "Population property was not set correctly");
        }

        [Test]
        public void CreateCityManagerAndPopulateWithCitiesTest()
        {
            // Cities we want managed
            City.City city1 = new City.City(500000);
            City.City city2 = new City.City(2500000);
            City.City city3 = new City.City(40000);

            Assert.IsNotNull(city1);
            Assert.IsNotNull(city2);
            Assert.IsNotNull(city3);

            // Add them to city manager
            CityManager cityManager = new CityManager();

            // List of cities should be instantiated when a citymanager is created
            Assert.IsNotNull(cityManager);
            Assert.IsNotNull(cityManager.Cities);

            cityManager.Add(city1);
            cityManager.Add(city2);
            cityManager.Add(city3);

            Assert.AreEqual(3, cityManager.Cities.Count, "City Manager did not add cities correctly");
            Assert.AreEqual(city1, cityManager.Cities[0], "Incorrect city was added to city manager");
            Assert.AreEqual(city2, cityManager.Cities[1], "Incorrect city was added to city manager");
            Assert.AreEqual(city3, cityManager.Cities[2], "Incorrect city was added to city manager");
        }
    }
}
