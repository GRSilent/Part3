namespace part3._1
{
    namespace ConsoleApp2
    {
        internal class firstPart
        {
            static void Main(string[] args)
            {
                Console.WriteLine("\nВведите число");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber % 2 == 0)
                {
                    Console.WriteLine("Введенное число четное");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Введенное число нечетное");
                    Console.ReadKey();
                }

            }
        }
    }
}