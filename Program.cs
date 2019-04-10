using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            {
                FiveOneTwoEigth.Width = 297.98;
                FiveOneTwoEigth.Depth = 297.98;
                FiveOneTwoEigth.Stories = 15;
                FiveOneTwoEigth.Construct().Purchase("Me");
            };



            Building FiveOneTwoNinth = new Building("456 9th Avenue");
            {
                FiveOneTwoNinth.Width = 297.98;
                FiveOneTwoNinth.Depth = 456.88;
                FiveOneTwoNinth.Stories = 15;
                FiveOneTwoNinth.Construct().Purchase("Mirang Sham");
            };



            List<Building> AllBuildings = new List<Building>() {
                FiveOneTwoEigth,
                FiveOneTwoNinth
            };

            // Create a city
            City niallville = new City("Niallville", 1945);

            // add buildings to city
            niallville.AddBuilding(FiveOneTwoEigth);
            niallville.AddBuilding(FiveOneTwoNinth);

            // elect mayor
            niallville.ElectMayor("Wyatt Fraser");

            Console.WriteLine(niallville);
            
            }
        }
    }
