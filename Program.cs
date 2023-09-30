using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            //Менюшка

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        UGADAIKA();
                        break;
                    case 2:
                        TablitsaUmnogeniya();
                        break;
                    case 3:
                        Deliteli();
                        break;
                    case 4:
                        return; 
                    default:
                        Console.WriteLine("Попробуй снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Попробуй снова.");
            }
        }
    }
    //кейс с выборкой менюшки

    static void UGADAIKA()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;

        Console.WriteLine("Игра 'Угадай число'");
        Console.WriteLine("Попробуй угадать число от 1 до 100.");

        while (true)
        {
            Console.Write("Введите вашу догадку: ");
            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                attempts++;

                if (guess == targetNumber)
                {
                    Console.WriteLine("Бинго, верно!");
                    break;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Число больше.");
                }
                else
                {
                    Console.WriteLine("Число меньше.");
                }
            }
            else
            {
                Console.WriteLine("Введи целое число.");
            }
        }
    }
    //Игра угадай число

    static void TablitsaUmnogeniya()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,3} ");
            }
            Console.WriteLine();
        }
    }
    //Таблица умножения

    static void Deliteli()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Делители: " + number);
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Введи целое число.");
        }
    }
}
//Делители от числа