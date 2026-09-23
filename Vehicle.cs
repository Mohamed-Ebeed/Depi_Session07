using System;

namespace Depi_Session07
{
    // Q13
    public class Vehicle : IVehicle
    {
        public virtual void MoveForward()
        {
            Console.WriteLine("Vehicle moves forward.");
        }

        public virtual void MoveBackward()
        {
            Console.WriteLine("Vehicle moves backward.");
        }

        public virtual void MoveUp()
        {
            Console.WriteLine("Vehicle moves up.");
        }

        public virtual void MoveDown()
        {
            Console.WriteLine("Vehicle moves down.");
        }
    }
} 
