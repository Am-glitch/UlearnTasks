using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //int[][] lines = new int[n][];

            //for (int i = 0; i < n; i++)
            //{
            //    string lineDescription = Console.ReadLine();
            //    int[] stations = lineDescription.Split(' ').Select(int.Parse).ToArray();
            //    lines[i] = stations;
            //}

            //int[] pings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var possibleStations = FindPossibleStations(n, lines, pings);

            //foreach (var station in possibleStations)
            //{
            //    Console.WriteLine(station);
            //}


            // 1 1 2 3 5 8 13 21 34 55
            Console.WriteLine(Fibonacci.FindNthFibonacci(10)); //55
        }

        //public static IEnumerable<int> FindPossibleStations(int n, IEnumerable<IEnumerable<int>> lines, IEnumerable<int> pings)
        //{
        //    var intersectingStations = lines.SelectMany(line => line).Distinct(); // Все станции, включая точки пересечения
        //    var visitedStations = new HashSet<int>(pings); // Посещенные станции (полученные пеленги)

        //    var possibleStations = intersectingStations.Where(station => !visitedStations.Contains(station));

        //    return possibleStations.OrderBy(station => station);
        //}

    }
}
