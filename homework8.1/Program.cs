﻿/*
ЗАДАЧА:
● Создать класс, описывающий пылесос
○ В классе должен быть виртуальное свойство Model для получения наименования модели пылесоса
○ В классе должен быть виртуальный метод StartCleaning, который пишет в консоль о том, что началась
уборка
○ Создать перегрузку метода StartCleaning, которая принимает параметром комнату, в которой нужно
сделать уборку
● Создать 3 класса наследника
○ Например: обычный пылесос, робот пылесос, моющий пылесос и тд
○ В 1 наследнике оставить тело метода StartCleaning родителя
○ В 2 наследнике переопределить метод StartCleaning, написав в начале уборки о том, какая модель
пылесоса начала уборку
○ В 3 наследнике реализовать сокрытие метода StartCleaning
● Каждый класс описать в отдельном файле
● Создать массив базового типа, добавить в него объекты класса пылесос. В цикле у
всех объектов вызвать метод StartCleaning
 */
using System;
using System.Reflection.Emit;
using System.Text;
using homework8._1.Rooms;
using homework8._1.Vacuum_Cleaner;

namespace homework8._1
{
    class Program
    {
        public static void Main()
        {
            //Создаем объекты-пылесосы и помещаем их в массив
            VacuumClass[] vacuums =
            {
                new ManualVacuum("1"),
                new RoboticVacuum("2"),
                new WhashingVacuum("3")
            };

            string CalculateVacuums(VacuumClass[] vacuums)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var vacuum in vacuums)
                {
                    var str = $"{vacuum.StartCleaning()}";
                    sb.AppendLine(str);
                }

                return sb.ToString();
            }


            //Создаем объекты комнат и помещаем их в массив
            // RoomClass[] rooms = 
            // {
            //     new HallRoom(10,6),
            //     new KitchenRoom(8),
            //     new SleepingRoom(8, 5)
            // };
            //
            // //Подсчитываем общую площадь всех комнат
            // string CalculateRoomArea()
            // {
            //     StringBuilder sb = new StringBuilder();
            //     foreach (var room in rooms)
            //     {
            //         room.
            //     }
            //     return
            // }
        }
    }
}