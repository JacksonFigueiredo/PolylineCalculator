using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolylineCalculator
{
    public class StationOffset
    {
        public double Station { get; }
        public double Offset { get; }

        public StationOffset(double station, double offset)
        {
            Station = station;
            Offset = offset;
        }
    }
}
