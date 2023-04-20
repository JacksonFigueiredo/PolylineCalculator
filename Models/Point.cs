using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolylineCalculator.Models
{
    public class Point
    {
        public double Easting { get; }
        public double Northing { get; }

        public Point(double easting, double northing)
        {
            Easting = easting;
            Northing = northing;
        }
    }
}
