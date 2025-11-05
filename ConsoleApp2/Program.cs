namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een leeftijd in: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                Console.WriteLine("Je bent " + age + " jaar oud.");
            }
            else
            {
                Console.WriteLine("Dat is geen geldig getal.");
            }
        }
    }
}
