using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class FuelEconomyExpection : Exception
    {
        public FuelEconomyExpection(double fuelEcon) : base($"Fuel Economy ({fuelEcon}) cannot be 0 or less.")
        {
        }
    }

    class NoFuelException : Exception
    {
        public NoFuelException() : base("Not enough fuel.")
        {

        }
    }
}
