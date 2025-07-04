using Exam.Classes;
using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            TrolleybusStation trolleybusStation = new TrolleybusStation();
            int ListLength;

        //проверка корректности ввода длины массива
            while (true)
            {
                Console.WriteLine("Введите количество элементов массива");
                bool isValid = int.TryParse(Console.ReadLine(), out ListLength);

                if (ListLength <= 0)
                    isValid = false;

                if (isValid)
                    break;
                else
                {
                    Console.WriteLine("Неверный формат данных. Повторите ввод");
                }
            }

            //заполнение массива
            for (int i = 0; i < ListLength; i ++)
            {
                Console.WriteLine("Введите номер маршрута");

                string NumberOfRoute = Console.ReadLine();
                int StationQuantity;
                int WayTime;

                //Проверка на корректность ввода StationQuantity
                while (true)
                {
                    Console.WriteLine("Введите количество станций");
                    bool isValid = int.TryParse(Console.ReadLine(), out StationQuantity);

                    if (StationQuantity <= 0)
                        isValid = false;
                    if (isValid)
                        break;
                    else
                    {
                        Console.WriteLine("Неверный формат данных. Повторите ввод");
                    }
                }

                //Проверка на корректность ввода WayTime
                while (true)
                {
                    Console.WriteLine("Введите продолжительность маршрута в минутах");

                   bool isValid = int.TryParse(Console.ReadLine(), out WayTime);

                    if (WayTime <= 0)
                        isValid = false;

                    if (isValid)
                        break;
                    else
                    {
                        Console.WriteLine("Неверный формат данных. Повторите ввод");
                    }
                }
                
                Route route = new Route(NumberOfRoute, StationQuantity, WayTime);
                trolleybusStation.AddRoute(route);
            }

            Console.WriteLine();
            Console.WriteLine("Вы заполнили массив следущими данными:");
            trolleybusStation.ShowAll();
            
            //Сортировка массива
            Console.WriteLine();
            Console.WriteLine("Данные после сортировки по возрастанию\n" +
                "(по сочетанию значений двух свойств в порядке убывания приоритета: «число остановок» и «время в пути») ");
            trolleybusStation.SortByStationQuantityAndWayTime();
            trolleybusStation.ShowAll();
            //Запись в файл
            Console.WriteLine();
            trolleybusStation.SaveToTxtFile("trolleybuses.txt");

        }
    }
}
