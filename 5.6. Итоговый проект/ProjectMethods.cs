using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6.Итоговый_проект
{
    public class ProjectMethods
    {

        public static (string name, string lastName, int age, string[] pets, string[] colors) GetUserData()
        {
            (string name, string lastName, int age, string[] pets, string[] colors) user;

            Console.WriteLine("Введите имя");
            user.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            user.lastName = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            user.age = GetIntNumber();

            Console.WriteLine("Есть ли у Вас питомец?");
            bool havePet = GetBool();
            int numberOfPets = 0;

            if (havePet)
            {
                Console.WriteLine("Напишите количество питомцев");
                numberOfPets = GetIntNumber();
                user.pets = GetPetsNames(numberOfPets);
            }
            else
            {
                user.pets = new string[0];
            }

            Console.WriteLine("Сколько у Вас любимых цветов?");
            int numberOfColor = GetIntNumber();
            user.colors = GetColorsNames(numberOfColor);


            return user;
        }

        public static int GetIntNumber()
        {
            int number;
            bool isNumberCorrect;
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
            while (!isNumberCorrect || number < 1)
            {
                Console.WriteLine("Напишите, пожалуйста, верное значение");
                isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public static string[] GetPetsNames(int numberOfPets)
        {
            string[] names = new string[numberOfPets];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Напишите имя питомца {i+1}");
                names[i] = Console.ReadLine();
            }
            return names;
        }

        public static string[] GetColorsNames(int numberOfColors)
        {
            string[] colors = new string[numberOfColors];
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"Напишите название цвета  {i+1}");
                colors[i] = Console.ReadLine();
            }
            return colors;
        }

        public static bool GetBool()
        {
            bool respons;
            bool isNumberCorrect = bool.TryParse(Console.ReadLine(), out respons);
            while (!isNumberCorrect)
            {
                Console.WriteLine("Укажите \"true\" or \"false\":");
                isNumberCorrect = bool.TryParse(Console.ReadLine(), out respons);
            }
            return respons;
        }

        public static void PrintUserData((string name, string lastName, int age, string[] pets, string[] colors) user)
        {
            Console.WriteLine($"Name: {user.name}");
            Console.WriteLine($"Lastname: {user.lastName}");
            Console.WriteLine($"Age: {user.age}");
            if (user.pets.Length > 0)
            {
                for (int i = 0; i < user.pets.Length; i++)
                {
                    Console.WriteLine(user.pets[i]);
                }
            }

            if (user.colors.Length > 0)
            {
                foreach (var color in user.colors)
                {
                    Console.WriteLine(color);
                }
            }
        }


    }
}
