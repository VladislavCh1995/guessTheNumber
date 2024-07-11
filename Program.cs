using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, lower, larger;
            int tryCount = 5;
            Random rand = new Random();
            int userInput;

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            larger = rand.Next(number + 1, number + 10);

            Console.WriteLine("Мы загадали число от 0 до 100, оно больше чем " + lower + " но меньше, чем " + larger);
            Console.WriteLine("Какое это число?");

            while (tryCount--  > 0)
            {
                userInput =Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Ответ неверен =(. Осталось {tryCount} попыток");
                }
            }

            if (tryCount < 0)
            {
                Console.WriteLine("Вы проиграли=(.");
            }
            else
            {
                Console.WriteLine("Вы выиграли!");
            }
        }
    }
}
