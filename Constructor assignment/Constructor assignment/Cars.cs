using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_assignment
{
    public class CarCount
    {
        public CarCount(int OwnedCars) : this(OwnedCars, 2) //Chain two constructors together.
        {
        }
        public CarCount(int OwnedCars, int DesiredCars)
        {
            ownedCars = OwnedCars ;
            desiredCars = DesiredCars ;
        }
        // Properties in the class 
        public int ownedCars { get; set; }
        public int desiredCars { get; set; }
        public bool Hoarder(int ownedCars, int desiredCars)
        {
            if (ownedCars + desiredCars >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
