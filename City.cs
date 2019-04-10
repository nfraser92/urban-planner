using System;
using System.Collections.Generic;
using System.Text;

namespace Planner
{
    public  class City {

        /*
            Now you need to create a type to represent your city. Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.

            Name of the city.
            The mayor of the city.
            Year the city was established.
            A collection of all of the buildings in the city.
            A method to add a building to the city.
            Remember, each class should be in its own file. Create a City.cs file and define the City class in there.
            Make sure it's in the same namespace as your other classes.

            Once the class is defined to your liking, refactor your code in Main()
            to create a new city instance and add your buildings to it.
            Once all buildings are in the city, refactor your code that outputs the building info
            to the console to be inside a foreach loop that iterate the city's building collection.
         */

         private string _CityName;

         private int _yearEst;

         private string _MayorName;

         public List<Building> AllBuildings { get; set; } = new List<Building>();

        public City (string name, int yearEst)
        {
            _CityName = name;
            _yearEst = yearEst;
        }

        public void ElectMayor (string mayor)
        {
            _MayorName = mayor;
        }
        public void AddBuilding (Building building)
        {
            AllBuildings.Add(building);
        }

        public string GetName(string name)
        {
            return _CityName;
        }
        public int GeYearEst(int year)
        {
            return _yearEst;
        }
        public string Mayor(string name)
        {
            return _MayorName;
        }
        public override string ToString() {
            StringBuilder output = new StringBuilder($@"
{_CityName}

Mayor: {_MayorName}
Year founded: {_yearEst}
Buildings:
");
            AllBuildings.ForEach(b => output.Append($"{b}\n"));
            return output.ToString();
        }
    }
}