namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");
            int ammountOfNumbers = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            Console.WriteLine("Введите числa последовательности");
            for (int i = 0; i < ammountOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < min) 
                {
                    min = number;
                }
             
            }
            Console.WriteLine("Наименьшее число:" + min);

        }
    }
}