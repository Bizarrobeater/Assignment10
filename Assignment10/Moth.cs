using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    // Class for assignment 10ø4
    class Moth
    {
        float[] initialPos = new float[2];
        float[] currentPos;

        public Moth(float xPos, float yPos)
        {
            initialPos[0] = xPos;
            initialPos[1] = yPos;
            currentPos = initialPos;
        }

        public void MoveToLight()
        {
            currentPos[0] = currentPos[0] / 2;
            currentPos[1] = currentPos[1] / 2;
        }

        public float[] GetPosition() => currentPos;
    }
}
