/************************************************************************************/
/* Практическая работа №10                                                           */
/* Выполнила: Корнеева В.Е., 2-ИСП                                                  */
/* Задание: Cоставить программу нахождения наибольшего нечетного значения в матрице.*/
/************************************************************************************/
using System;

namespace PR_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    Console.Title = "Практическая работа №10";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Здравствуйте!!!");
                    double[,] m = new double[4,3];
                    Random r = new Random(); 
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            m[i, j] = r.NextDouble() * (38 - (-27)) + (-27);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваша матрица:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("  " + Math.Round(m[i, j], 3));
                        }
                        Console.WriteLine();
                    }
                    double max = double.MinValue;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Math.Round(m[i, j],3) % 2 != 0 && Math.Round(m[i, j],3) > max)
                            {
                                max = Math.Round(m[i, j], 3);
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Наибольшее нечетное число в матрице: {Math.Round(max, 3)}");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Хотите выполнить команду еще раз? \nНажмите Y для продолжение программы, иначе любую другую кнопку для завершения!");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Программа завершена. \tДо свидания!");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (IndexOutOfRangeException iex) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что-то пошло не так... \tОшибка: " + iex.Message);
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}