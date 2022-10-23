using System;
using System.Threading;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte mode;

                Console.Write("Консольный калькулятор\nВыберете режим (1 = рандом, 2 = калькулятор): ");
                mode = Convert.ToByte(Console.ReadLine());

                for (int i = 0; i < 22; i++)
                {
                    Console.Write('=');
                    Thread.Sleep(50);
                }

                switch (mode)
                {
                    case 1:
                        int maxr;

                        Console.Write("\nВведите максимальное число: ");
                        maxr = Convert.ToInt32(Console.ReadLine());

                        Random random = new Random();
                        Console.WriteLine($"Рандомное число: {random.Next(maxr)}");
                        Console.ReadLine();
                        break;
                    case 2:
                        string operation;
                        long ac;
                        long bc;

                        Console.Write("\nОперация (+, -, /, *, %): ");
                        operation = Console.ReadLine();

                        Console.Write("Введите первое число: ");
                        ac = Convert.ToInt64(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        bc = Convert.ToInt64(Console.ReadLine());

                        switch (operation)
                        {
                            case "+":
                                Console.WriteLine($"Ответ: {ac + bc}");
                                Console.ReadLine();
                                break;
                            case "-":
                                Console.WriteLine($"Ответ: {ac - bc}");
                                Console.ReadLine();
                                break;
                            case "/":
                                Console.WriteLine($"Ответ: {ac / bc}");
                                Console.ReadLine();
                                break;
                            case "*":
                                Console.WriteLine($"Ответ: {ac * bc}");
                                Console.ReadLine();
                                break;
                            case "%":
                                Console.WriteLine($"Ответ: {ac % bc}");
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Не верная операция!");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\nНе верный режим!");
                        Console.ReadLine();
                        break;
                }
            } catch(Exception) {
                for (int i = 0; i < 22; i++)
                {
                    Console.Write('=');
                    Thread.Sleep(50);
                }
                Console.WriteLine("\nПроизошла ошибка");
                Console.ReadLine();
            }
        }
    }
}
