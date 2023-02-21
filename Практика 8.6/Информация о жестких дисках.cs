using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DriveManager
    {
    class Program

    {

        public void PrintDirectoryInfo()                                   //Напишите метод, который считает количество файлов и папок
                                                                           //в корне вашего диска и выводит итоговое количество объектов.

        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\");                                       //Создаем объект dirInfo типа данных DirectoryInfo
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);           //
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        


        }
            static void Main(string[] args)
            {
                // получим системные диски
                DriveInfo[] drives = DriveInfo.GetDrives();
             
                // Пробежимся по дискам и выведем их свойства
                foreach (DriveInfo drive in drives)
                {
                    Console.WriteLine($"Название: {drive.Name}");
                    Console.WriteLine($"Тип: {drive.DriveType}");
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Объем: {drive.TotalSize}");
                        Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                        Console.WriteLine($"Метка: {drive.VolumeLabel}");
                    }
                }
            }
        }
    }
