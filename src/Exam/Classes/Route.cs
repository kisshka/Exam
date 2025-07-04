using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Classes
{
   public class Route
    {
        public string NumberOfRoute;
        public int StationQuantity;
        public int WayTime;

        public Route(string NumberOfRoute,int StationQuantity, int WayTime)
        {
            this.NumberOfRoute = NumberOfRoute;
            this.StationQuantity = StationQuantity;
            this.WayTime = WayTime;
        }
    }
}
