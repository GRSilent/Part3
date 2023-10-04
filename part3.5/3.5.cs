namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное целое число диапазона");
            int maxBorder = int.Parse(Console.ReadLine());

            Random randomize = new Random();
            int randomResult = randomize.Next(maxBorder + 1);
            do
            {
                Console.WriteLine("\nВведите число");
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber > randomResult)
                {
                    Console.WriteLine("\nЗагаданное число меньше вашего. Попробуйте еще раз");
                    
                }
                else if (inputNumber < randomResult)
                {
                    Console.WriteLine("\nЗагаданное число больше вашего. Попробуйте еще раз");
                  
                }
                else
                {

                    Console.WriteLine("\nВы угадали число!!!");
                    break;
                    
                }

            } while (true);
            Console.ReadKey();

        }
    }
}