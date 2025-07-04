using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam.Classes
{
    public class TrolleybusStation
    {
        public List<Route> Routes = new List<Route>();

        public void AddRoute(Route route)
        {
            Routes.Add(route);
        }

        public void ShowAll()
        {
            for (int i = 0; i < Routes.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}|Маршрут №{Routes[i].NumberOfRoute}" +
                    $" |Число остановок: {Routes[i].StationQuantity} |Время в пути: {Routes[i].WayTime}");
            }
        }

        public void SortByStationQuantityAndWayTime()
        {
            for (int i = 1; i < Routes.Count; i++)
            {
                Route TempRoute = Routes[i];
                int j = i - 1;

                while (j >= 0 && isRight(Routes[j], TempRoute))
                {
                    Routes[j + 1] = Routes[j];
                    Routes[j] = TempRoute;
                    j--;
                }
            }
        }

        //Проверяет,стоит ли продолжать сдвиг в сортировке
        public bool isRight(Route route, Route tempRoute ) {

            if (tempRoute.StationQuantity < route.StationQuantity)
                return true;
            else if (tempRoute.StationQuantity == route.StationQuantity)
            {
                if(tempRoute.WayTime < route.WayTime)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
             return false;
        }

        public void SaveToTxtFile(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < Routes.Count; i++)
                {
                    streamWriter.WriteLine($"{i + 1}|Маршрут №{Routes[i].NumberOfRoute}" +
                        $" Число остановок: {Routes[i].StationQuantity} Время в пути: {Routes[i].WayTime}");
                }
            }

            Console.WriteLine($"Данные были успешно записаны в файл {path}");
                 
        }

    }
}
