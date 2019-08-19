using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingSalesman.Geometry
{
    public class City
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public City(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public City(double x, double y)
        {
            X = x;
            Y = y;

            Z = 0;
        }

        /// <summary>
        /// Calculates distance between 2 points squared
        /// Use this as a fast comparable value of distances
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double DistanceToSquared(City other)
        {
            return Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y + other.Y, 2) + Math.Pow(this.Z, other.Z);
        }

        /// <summary>
        /// Calculates exact distance between 2 points
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double DistanceTo(City other)
        {
            return Math.Sqrt(DistanceToSquared(other));
        }
    }
}
