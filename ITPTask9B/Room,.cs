using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPTask9B
{
    internal class Room_
    {
        public Room_(double lenght, double breadth, double height)
        {
            Lenght = lenght;
            Breadth = breadth;
            Height = height;
        }

        public double Lenght { get; set; }
        public double Breadth { get; set; }
        double Height { get; set; }
    

        public double CalculateFloorArea()
        {
        return Lenght * Breadth;
        }

        public double CalculateWallArea()
        {
            return 2 * (Lenght * Height) + 2 * (Breadth * Height);
        }

    }
}
