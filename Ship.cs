using System;

namespace Depi_Session07
{
    // Q11 + Q14
    public class Ship : IMoveable
    {
        void IMoveable.MoveForward()
        {
            Console.WriteLine("Ship moves forward on the sea.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Ship moves backward on the sea.");
        }
    }
} 
