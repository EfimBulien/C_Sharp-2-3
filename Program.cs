namespace Program2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key;
            do
            {
                Console.WriteLine("\nВыберете программу, которую вы хотите запустить");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Закрыть программу");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Угадай число от 0 до 100!");
                        Random random = new Random();
                        int R = random.Next(0, 100);
                        int number;
                        do
                        {
                            number = Convert.ToInt32(Console.ReadLine());
                            if (number == R)
                            {
                                Console.WriteLine("Вы угадали!");
                               
                            }
                            else if (number < R)
                            {
                                Console.WriteLine("Надо больше");
                            }
                            else
                            {
                                Console.WriteLine("Надо меньше");
                            }
                        }while( number != R);
                        break;
                    case 2:
                        string[,] table = new string[10, 10];
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                table[i, j] = ((i + 1) * (j + 1)).ToString();
                                Console.Write(table[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите число ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            if (num % i == 0)
                            {
                                Console.Write(i + "\t");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Программа завершила свою работу");
                        break;
                }
            } while (key != 4);
        }
    }
}