using System;

namespace Praktika2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хочешь сыграть в угадай число? 1 - да; 2 - нет");

            int request = Convert.ToInt32(Console.ReadLine());

            if (request == 1)
            {
                Console.WriteLine("Начни вводить число от 0 до 101, я уже сгенерировал его и буду давать подсказки");

                Random random = new Random();
                int randomNumber = random.Next(0, 101);

                int guess = Convert.ToInt32(Console.ReadLine());

                while (randomNumber != guess)
                {
                    if (randomNumber > guess)
                    {
                        Console.WriteLine("Загаданное число больше");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (randomNumber < guess)
                    {
                        Console.WriteLine("Загаданное число меньше");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Поздравляю! Вы угадали!");
            }
            else if (request == 2)
            {
                Console.WriteLine("Ну, значит не сегодня");
            }
        }
    }
}