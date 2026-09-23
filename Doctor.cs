namespace Depi_Session07
{
    // Q6
    // Doctor hides Greet() using new
    // and overrides Display().

    public class Doctor : Person
    {
        public string Specialty { get; set; }

        public new void Greet()
        {
            System.Console.WriteLine("I am a Doctor.");
        }

        public override void Display()
        {
            System.Console.WriteLine(
                $"ID: {ID}, Name: {Name}, Age: {Age}, Specialty: {Specialty}"
            );
        }
    }
} 
