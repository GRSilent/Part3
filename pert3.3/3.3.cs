namespace pert3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            Console.WriteLine("Введите целое число");
            int number = int.Parse(Console.ReadLine());
            int a = 2;

            while (a <= number - 1) 
            {
                if (number % a == 0)
                {
                    result = true;
                    break;
                }
                a++;
                
            } 


            if (result)
            {
                Console.WriteLine("Число не является простым");
            }
            else Console.WriteLine("Число является простым");
        }
    }
}