namespace Depi_Session07
{
    // Q5
    // Person has ID, Name, Age.
    // Greet() is non-virtual.
    // Display() is virtual.

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            System.Console.WriteLine("I am a person's basic data. Person.");
        }

        public virtual void Display()
        {
            System.Console.WriteLine(
                $"ID: {ID}, Name: {Name}, Age: {Age}"
            );
        }
    }
} 
