using PolylineCalculator.Implementation;
using PolylineCalculator.Models;

namespace PolylineCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read polyline data from file
            List<Point> polyline = Methods.ReadPolylineFromFile("input.csv");

            // Get point coordinates from user
            Console.Write("Enter Easting value: ");
            double easting = double.Parse(Console.ReadLine());
            Console.Write("Enter Northing value: ");
            double northing = double.Parse(Console.ReadLine());
            Point point = new Point(easting, northing);

            // Calculate station and offset
            StationOffset stationOffset = Methods.CalculateStationOffset(point, polyline);

            // Display results
            Console.WriteLine($"Station: {stationOffset.Station}, Offset: {stationOffset.Offset}");
        }
    }
}