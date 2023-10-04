namespace part3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый вечер! сколько у вас карт в руке?");
            int ammountOfCards = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int c = 0; c < ammountOfCards; c++) 
            {
                Console.WriteLine("\nВведите номинал карты");
                Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                string cardWeight = Console.ReadLine();
        
                switch (cardWeight) 
                {
                    case "J":
                        sum = sum + 10;
                        break;
                    case "Q":
                        sum = sum + 10;
                        break;
                    case "K":
                        sum = sum + 10;
                        break;
                    case "T":
                        sum = sum + 10;
                        break;
                    case "2":
                        sum = sum + 2;
                        break;
                    case "3":
                        sum = sum + 3;
                        break;
                    case "4":
                        sum = sum + 4;
                        break;
                    case "5":
                        sum = sum + 5;
                        break;
                    case "6":
                        sum = sum + 6;
                        break;
                    case "7":
                        sum = sum + 7;
                        break;
                    case "8":
                        sum = sum + 8;
                        break;
                    case "9":
                        sum = sum + 9;
                        break;
                    case "10":
                        sum = sum + 10;
                        break;
                    default:
                        Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                        c--;
                        break;
                }
            }

            Console.WriteLine("\nСумма карт:" + sum);
            Console.ReadLine();
        }
    }
}