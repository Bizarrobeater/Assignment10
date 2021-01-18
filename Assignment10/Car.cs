using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    // Class for assigment 10ø3
    class Car
    {
        double fuelEconKmPerLiter;
        double fuelLeft;
        public double KmDriven { get; private set; }

        public Car(double fuelEconKmPerLiter)
        {
            if (fuelEconKmPerLiter <= 0)
            {
                throw new FuelEconomyExpection(fuelEconKmPerLiter);
            }
            KmDriven = 0.0;
            fuelLeft = 0.0;
            this.fuelEconKmPerLiter = fuelEconKmPerLiter;
        }

        public void AddGas(double fuelToAdd) => fuelLeft += fuelToAdd;

        public double GasLeft => fuelLeft;

        public void Drive(double kmDriven)
        {
            double fuelRequired = kmDriven / fuelEconKmPerLiter;
            if (fuelLeft > fuelRequired)
            {
                this.KmDriven += kmDriven;
                fuelLeft -= fuelRequired;
            }
            else
            {
                throw new NoFuelException();
            }
        }



    }


}
