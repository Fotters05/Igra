using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayGuessTheNumber();
                    break;
                case 2:
                    PrintMultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void PlayGuessTheNumber()
    {
        Console.WriteLine("Игра 'Угадай число'");
        Random random = new Random();
        int targetNumber = random.Next(101);
        int attempts = 0;

        while (true)
        {
            Console.Write("Введите число от 0 до 100: \n ");
            int userGuess = int.Parse(Console.ReadLine());
            attempts++;

            if (userGuess == targetNumber)
            {
                Console.WriteLine("Харош угадал число");
                return;
            }
            else if (userGuess < targetNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }
    }

    static void PrintMultiplicationTable()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Делители числа {number}: ");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}