using System;

namespace Planner
{
    public class Building
    {
        /*
            _designer of type string. It will hold your name.
            _dateConstructed of type DateTime. This will hold the exact time the building was created.
            _address of type string.
            _owner of type string. This will store the same of the person who owns the building.
            Stories typed as an integer.
            Width typed as a double.
            Depth typed as a double.
            Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
         */
        private string _designer = "Niall Fraser";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        private double _width;

        public double Width {
            get {
                return _width;
            }

            set {
                if (Width < 10)
                {
                    _width = value;
                }
            }
        }


        public int Stories { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
          get  {
                return Width * Depth * (3 * Stories);
            }
        }
        /*
            Define a constructor method that accepts a single string argument - address -
            so that you can send as a parameter when you create each instance with new Building("800 8th Street");.

            The constructor's logic should set the _address field's value to the argument value

         */
        public Building(string address)
        {
            _address = address;
        }

        /*
            Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
            Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building.
            The method should take that string and assign it to the private _owner field.
            Neither of these methods will return a value.
         */
         public Building Construct () {
             _dateConstructed = DateTime.Now;
             return this;
         }

         public Building Purchase (string name) {
             _owner = name;
            //  return this is a reference to the object. The building that you are currently in
             return this;
         }

         public string GetDesigner() {
             return _designer;
         }
         public string GetOwner() {
             return _owner;
         }
         public DateTime BuildDate() {
             return _dateConstructed;
         }

         public override string ToString () {
                return $@"
{_address}
-------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space
                ";
            }
    }
}