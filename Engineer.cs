namespace Depi_Session07
{
    // Q6
    // Engineer hides Greet() using new
    // and overrides Display().

    public class Engineer : Person
    {
        public string Field { get; set; }

        public new void Greet()
        {
            System.Console.WriteLine("I am an Engineer.");
        }

        public override void Display()
        {
            System.Console.WriteLine(
                $"ID: {ID}, Name: {Name}, Age: {Age}, Field: {Field}"
            );
        }
    }
} 
