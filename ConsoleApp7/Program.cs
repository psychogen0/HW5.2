namespace HW_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered a number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("It's not a number!");
            }

        }
    }
}