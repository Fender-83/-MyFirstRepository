using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _5._6.Итоговый_проект
{
    internal class Program
    {
        static void Main(string[] args)

        //Необходимо создать метод, который заполняет данные с клавиатуры по пользователю(возвращает кортеж) :
        //        Имя;
        //        Фамилия;
        //        Возраст;
        //        Наличие питомца;
        //Если питомец есть, то запросить количество питомцев;
        //Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
        //Запросить количество любимых цветов;
        //Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
        //Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
        //Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
        //Корректный ввод: ввод числа типа int больше 0.
        //Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        //Вызов методов из метода Main.
        {
            Console.WriteLine("Задание 5.6. \nИтоговый проект.");
            Console.WriteLine();

            (string name, string lastName, int age, string[] pets, string[] colors) userDate = ProjectMethods.GetUserData();

            Console.Clear();
            Console.WriteLine("\n\n");

            ProjectMethods.PrintUserData(userDate);

            Console.ReadKey();


        }
    }
}
