using System;

namespace Depi_Session07
{
    // Q11
    public class Car : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Car moves forward on the ground.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car moves backward on the ground.");
        }
    }
} 
