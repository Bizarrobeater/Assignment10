using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //Another car Class this for assignment 10ø5
    class NCar
    {
        int yearOfModel;
        string make;
        float speed;

        double fuelLeft;
        public double KmDriven { get; private set; }

        public NCar(int yearOfModel, string make)
        {
            this.yearOfModel = yearOfModel;
            this.make = make;
            speed = 0f;
        }

        public float GetSpeed() => speed;

        public void Accelerate()
        {
            if (fuelLeft < 0.5f)
            {
                throw new NoFuelException();
            }
            speed += 5;
            fuelLeft -= 0.5f;
        }

        public void Brake() 
        {
            if(fuelLeft < 0.5f)
            {
                throw new NoFuelException();
            }
            speed -= 5;
            fuelLeft -= 0.5f;
        }

        public void AddGas(double fuelToAdd) => fuelLeft += fuelToAdd;
        public double GasLeft => fuelLeft;

    }
}
