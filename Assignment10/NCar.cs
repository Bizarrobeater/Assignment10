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

        public NCar(int yearOfModel, string make)
        {
            this.yearOfModel = yearOfModel;
            this.make = make;
            speed = 0f;
        }

        public float GetSpeed() => speed;

        public void Accelerate() => speed += 5;

        public void Brake() => speed -= 5;

    }
}
