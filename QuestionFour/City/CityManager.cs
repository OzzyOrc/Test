using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour.City
{
    public class CityManager
    {
        private List<City> cities = new List<City>();

        /// <summary>
        /// Builder class abstracted out for managing cities
        /// </summary>
        public CityManager()
        {
            Cities = new List<City>();
        }

        public List<City> Cities
        {
            get
            {
                return cities;
            }
            private set
            {
                cities = value;
            }
        }

        public void Add(City city)
        {
            Cities.Add(city);
        }
    }
}
