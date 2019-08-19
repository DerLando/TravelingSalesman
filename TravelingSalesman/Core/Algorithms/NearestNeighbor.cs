using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelingSalesman.Geometry;

namespace TravelingSalesman.Core.Algorithms
{
    /// <summary>
    /// Implementation of the nearest neighbor algorithm
    /// Basically you pick a start point and always pick the nearest point from there
    /// On average 25% worse then the best possible solution
    /// </summary>
    public class NearestNeighbor
    {
        public static City[] Solve(IEnumerable<City> cities, int startIndex=0)
        {
            // create array from cities
            var citiesArr = cities.ToList();

            // create empty int array for solved indices
            int[] solved = new int[citiesArr.Count];

            // set first element of solved array as supplied startIndex (or default value)
            solved[0] = startIndex;

            // iterate over solved array, starting at 1
            for (int i = 1; i < solved.Length; i++)
            {
                // find the next closest point in the cities array
                citiesArr.Min(c => c.DistanceToSquared(citiesArr[solved[i - 1]]));
                citiesArr.
            }


            return solved;
        }

        private static int NearestNeighborIndex(IEnumerable<City> cities, City start)
        {

        }

    }
}
