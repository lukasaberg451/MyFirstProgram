// Lukas Åberg, BUV26
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 6;

            // IF/ELSE to check if the number is greater than 10.
            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            // Ask for the users name and write it back to them.
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");

            // Loop to write numbers from 0 to the variable value on line 7.
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
