using PolylineCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolylineCalculator.Implementation
{
    public static class Methods
    {
       public static double CalculateStation(Point point, Point lineStart, Point lineEnd)
        {
            double dx = lineEnd.Easting - lineStart.Easting;
            double dy = lineEnd.Northing - lineStart.Northing;
            double dotProduct = (point.Easting - lineStart.Easting) * dx + (point.Northing - lineStart.Northing) * dy;
            double station = dotProduct / (dx * dx + dy * dy);
            return station;
        }

        public static double DistanceFromPointToLine(Point point, Point lineStart, Point lineEnd)
        {
            double dx = lineEnd.Easting - lineStart.Easting;
            double dy = lineEnd.Northing - lineStart.Northing;
            double numerator = Math.Abs(dy * point.Easting - dx * point.Northing + lineEnd.Easting * lineStart.Northing - lineEnd.Northing * lineStart.Easting);
            double denominator = Math.Sqrt(dx * dx + dy * dy);
            return numerator / denominator;
        }

        public static StationOffset CalculateStationOffset(Point point, List<Point> polyline)
        {
            double minDistance = double.MaxValue;
            double minStation = 0;
            for (int i = 1; i < polyline.Count; i++)
            {
                Point p1 = polyline[i - 1];
                Point p2 = polyline[i];
                double distance = DistanceFromPointToLine(point, p1, p2);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minStation = CalculateStation(point, p1, p2);
                }
            }
            return new StationOffset(minStation, minDistance);
        }

        public static List<Point> ReadPolylineFromFile(string filename)
        {
            List<Point> polyline = new List<Point>();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                double easting = double.Parse(parts[0]);
                double northing = double.Parse(parts[1]);
                Point point = new Point(easting, northing);
                polyline.Add(point);
            }
            return polyline;
        }
    }
}
