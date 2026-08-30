namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummer = 6;

            // IF/ELSE to check if the number is greater than 10
            if (nummer > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej, " + namn + "!");

        }
    }
}
