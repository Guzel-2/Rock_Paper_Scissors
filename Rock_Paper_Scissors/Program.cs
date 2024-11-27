using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "Камень", "Ножницы", "Бумага" };
            Random random = new Random();
            bool playAgain = true;

            Console.WriteLine("Добро пожаловать в игру 'Камень, Ножницы, Бумага'!");

            while (playAgain)
            {
                Console.WriteLine("\nВыберите: 0 - Камень, 1 - Ножницы, 2 - Бумага");
                int userChoice;


                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > 2)
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите 0, 1 или 2.");
                }

                int computerChoice = random.Next(0, 3); // Случайный выбор компьютера

                Console.WriteLine($"Вы выбрали: {options[userChoice]}");
                Console.WriteLine($"Компьютер выбрал: {options[computerChoice]}");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("Ничья!");
                }
                else if ((userChoice == 0 && computerChoice == 1) ||
                         (userChoice == 1 && computerChoice == 2) ||
                         (userChoice == 2 && computerChoice == 0))
                {
                    Console.WriteLine("Вы выиграли!");
                }
                else
                {
                    Console.WriteLine("Компьютер выиграл!");
                }

                // Запрос на повторную игру
                Console.WriteLine("\nХотите сыграть еще раз? (y/n)");
                string answer = Console.ReadLine().ToLower();
                playAgain = (answer == "y");
            }

            Console.WriteLine("Спасибо за игру!");
        }
    }
}
