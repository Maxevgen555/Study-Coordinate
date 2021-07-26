using System;
using System.Collections.Generic;
using System.Text;

namespace CoordinateConversion
{
    class MainCoord
    {
        double latitudeCoord;
        public double LatitudeCoord
        {
            get
            {
                return latitudeCoord;
            }
            set
            {
                latitudeCoord = LatitudeCoord;
            }
        }

        double longitudeCoord;
        public double LongitudeCoord
        {
            get
            {
                return longitudeCoord;
            }
            set
            {
                longitudeCoord = LongitudeCoord;
            }
        }

        public double ToMainCoord(string UserDergrees, string UserMinutes, string UserSecond)
        {
            double Dergrees = double.Parse(UserDergrees);
            double Minutes = double.Parse(UserMinutes);
            double Second = double.Parse(UserSecond);
            double MainDegrees = Dergrees + (Minutes / 60) + (Second / 3600);

            return MainDegrees;
        }
        public double ToMainCoord(string UserDergrees, string UserMinutes)
        {
            double Dergrees = double.Parse(UserDergrees);
            double Minutes = double.Parse(UserMinutes);
            double MainDegrees = Dergrees + (Minutes / 60);

            return MainDegrees;
        }
        public double ToMainCoord(string UserDergrees)
        {
            double Dergrees = double.Parse(UserDergrees);
            double MainDegrees = Dergrees;

            return MainDegrees;
        }
    }
}