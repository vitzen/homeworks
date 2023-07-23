﻿// Создать директорию
// Создать в ней 3 файла. Первый - с массивом чисел от 1 до 100.
// Второй - с текущей датов,
// Третий - со списком всех подкаталогов из c:/ProgramFiles (или любого другого)
//
// Считать информацию из файлов, созданных в пункте 2.
// Файл №2 перенести в новую директорию(ее нужно тоже создать, в любом месте)
// Перенести категорию №1 в категорию, созданную на шаге 4.
// Задание на FileStream. Считать из файла №1 только ту порцию информации,
// где хранятся числа от 10 до 20. Перезаписать их на числа от 200 до 210.

using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;


namespace homework21
{
    public class Program
    {
        public static void Main()
        {
            var drives = DriveInfo.GetDrives();
            var drive = drives.First();

            var directories = Directory.GetDirectories(drive.RootDirectory.FullName);
            var currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            try
            {
                var info = new DirectoryInfo(currentPath);
                var createdDirectory = info.CreateSubdirectory("MyDirectory");
                File.Create(Path.Combine(createdDirectory.FullName, "text.txt"));
                if (createdDirectory.Exists)
                {
                    Console.WriteLine("Директория успешно создана");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось создать директорию");
            }
        }
    }
}