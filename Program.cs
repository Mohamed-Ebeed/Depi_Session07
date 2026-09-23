using System;

namespace Depi_Session07
{
    internal class Program
    {
        // Q7
        // This method receives a Person reference
        // and calls Greet() and Display().
        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }

        static void Main(string[] args)
        {
            // =====================================================
            // PART 1 - STATIC BINDING
            // =====================================================

            // Q3
            Shape shape = new Shape(2, 3);

            Console.WriteLine("Q3 - Shape:");
            Console.WriteLine($"Area = {shape.Area()}");
            // Output: 6

            Cube cube = new Cube(2, 3, 4);

            Console.WriteLine("\nQ3 - Cube:");
            Console.WriteLine($"Area = {cube.Area()}");
            // Output: 24

            Shape shapeRef = new Cube(2, 3, 4);

            Console.WriteLine("\nQ3 - Shape Reference to Cube:");
            Console.WriteLine($"Area = {shapeRef.Area()}");
            // Output: 6

            /*
             Q3 Explanation:

             shape.Area() = 2 * 3 = 6

             cube.Area() = 2 * 3 * 4 = 24

             shapeRef.Area() = 6

             Why?

             Because Area() in Shape is not virtual.
             Cube hides Area() using the new keyword.

             Therefore the method is resolved at compile time
             according to the reference type.

             This is called Static Binding / Early Binding.
            */


            // Q4
            object obj = new Cube(1, 2, 3);

            Console.WriteLine("\nQ4 - Object ToString:");
            Console.WriteLine(obj.ToString());

            /*
             Q4 Explanation:

             ToString() is inherited from System.Object.

             Object.ToString() is virtual, so the runtime can
             choose the appropriate implementation.

             This demonstrates Late / Dynamic Binding.

             ToString() behaves polymorphically because it is virtual.

             Area() does not behave polymorphically because the
             Shape.Area() method is not virtual and Cube only hides it
             using new.
            */


            // =====================================================
            // PART 2 - DYNAMIC BINDING
            // =====================================================

            // Q5 + Q6
            Doctor doctor = new Doctor
            {
                ID = 1,
                Name = "Ahmed",
                Age = 35,
                Specialty = "Cardiology"
            };

            Engineer engineer = new Engineer
            {
                ID = 2,
                Name = "Sara",
                Age = 29,
                Field = "Software Engineering"
            };


            // Q7
            Person doctorPerson = doctor;
            Person engineerPerson = engineer;

            Console.WriteLine("\nQ7 - Doctor through Person reference:");
            ProcessPerson(doctorPerson);

            Console.WriteLine("\nQ7 - Engineer through Person reference:");
            ProcessPerson(engineerPerson);

            /*
             Q7 Explanation:

             Greet() is non-virtual.

             Therefore:
             person.Greet()
             calls Person.Greet().

             Display() is virtual.

             Therefore:
             doctorPerson.Display()
             calls Doctor.Display().

             engineerPerson.Display()
             calls Engineer.Display().

             Greet() is resolved at compile time.

             Display() is resolved at runtime.
            */


            // Q8
            /*
             Q8 Answer:

             If virtual is removed from Display() in Person,
             Doctor and Engineer cannot use override.

             The compiler will report an error because there is
             no suitable virtual or abstract base method to override.

             virtual is required in the base class before override
             can be used in the derived class.
            */


            // =====================================================
            // PART 3 - INTERFACES
            // =====================================================

            // Q9
            /*
             Q9 Answer:

             If every vehicle is forced to implement all four methods:

             MoveForward()
             MoveBackward()
             MoveUp()
             MoveDown()

             some vehicles will have methods they do not need.

             For example, a Car does not need MoveUp() or MoveDown().

             Interfaces solve this problem by separating capabilities.
            */


            // Q10 + Q11
            Car car = new Car();
            Ship ship = new Ship();
            Airplane airplane = new Airplane();

            Console.WriteLine("\nQ11 - Car:");

            car.MoveForward();
            car.MoveBackward();


            Console.WriteLine("\nQ11 - Ship:");

            IMoveable shipMoveable = ship;

            shipMoveable.MoveForward();
            shipMoveable.MoveBackward();


            Console.WriteLine("\nQ11 - Airplane:");

            airplane.MoveForward();
            airplane.MoveBackward();
            airplane.MoveUp();
            airplane.MoveDown();


            // Q12
            IMoveable carRef = new Car();

            Console.WriteLine("\nQ12 - Car through IMoveable:");

            carRef.MoveForward();
            carRef.MoveBackward();


            IMoveable planeRef = new Airplane();

            Console.WriteLine("\nQ12 - Airplane through IMoveable:");

            planeRef.MoveForward();
            planeRef.MoveBackward();


            /*
             Q12:

             Can we call:

             planeRef.MoveUp();

             NO.

             Because planeRef is declared as IMoveable.

             IMoveable contains only:

             MoveForward()
             MoveBackward()

             It does not contain MoveUp() or MoveDown().

             To call MoveUp() and MoveDown(), we need an IFlyable
             reference or an Airplane reference.
            */

            IFlyable planeFlyRef = new Airplane();

            Console.WriteLine("\nAirplane through IFlyable:");

            planeFlyRef.MoveUp();
            planeFlyRef.MoveDown();


            // =====================================================
            // Q13 - Interface Inheritance
            // =====================================================

            IVehicle vehicleRef = new Vehicle();

            Console.WriteLine("\nQ13 - Vehicle through IVehicle:");

            vehicleRef.MoveForward();
            vehicleRef.MoveBackward();
            vehicleRef.MoveUp();
            vehicleRef.MoveDown();

            /*
             Q13 Explanation:

             IVehicle inherits from:

             IMoveable
             IFlyable

             Therefore IVehicle contains all four methods.

             The benefit is that one interface can combine
             multiple related contracts.
            */


            // =====================================================
            // Q14 - Explicit Interface Implementation
            // =====================================================

            Ship explicitShip = new Ship();

            Console.WriteLine("\nQ14 - Explicit Interface Implementation:");

            IMoveable explicitShipRef = explicitShip;

            explicitShipRef.MoveForward();


            /*
             Q14 Explanation:

             Ship.MoveForward() was implemented explicitly:

             void IMoveable.MoveForward()

             Therefore it cannot be called directly like:

             Ship ship = new Ship();
             ship.MoveForward();

             Instead, it must be called through an IMoveable reference:

             IMoveable shipRef = new Ship();
             shipRef.MoveForward();
            */


            // =====================================================
            // Q15 - Comparison
            // =====================================================

            /*
             Q15:

             Static Binding (new):

             Keyword in base:
             No virtual is required.

             Keyword in derived:
             new

             Resolved at:
             Compile time

             Behavior via base reference:
             Base version


             Dynamic Binding (override):

             Keyword in base:
             virtual

             Keyword in derived:
             override

             Resolved at:
             Runtime

             Behavior via base reference:
             Derived version
            */


            // =====================================================
            // Q16
            // =====================================================

            /*
             Q16:

             C# requires virtual in the base class before override
             because override is used for runtime polymorphism.

             The base method must be virtual or abstract so that
             the derived class can provide another implementation
             for the same virtual member.

             The new keyword is different.

             new means method hiding.

             It does not replace the base method in the polymorphic
             dispatch system, so the base method does not have to
             be virtual.
            */


            Console.WriteLine("\n=================================");
            Console.WriteLine("Assignment Completed Successfully");
            Console.WriteLine("=================================");

            Console.ReadKey();
        }
    }
} 
