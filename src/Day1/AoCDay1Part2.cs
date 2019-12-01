using System.Collections.Generic;
using System.Linq;

namespace AoC2019.Day1
{
    public class AoCDay1Part2 : AoCDay 
    {
        protected override AoCStatus Status => AoCStatus.Done;

        protected override void Execute(string[] inputLines)
        {
            var result = inputLines
                .Select(int.Parse)
                .Select(this.CalculateFuelRecursive)
                .Sum();

            System.Console.WriteLine(result);
        }

        private int CalculateFuelRecursive(int weight)
        {
            var fuelList = new List<int>();

            int currentWeight = weight;

            while (true)
            {
                var fuel = this.CalculateFuel(currentWeight);
                
                if (fuel == 0)
                    break;

                fuelList.Add(fuel);
                currentWeight = fuel;
            }

            return fuelList.Sum();
        }

        private int CalculateFuel(int weight)
        {
            var fuel = (weight / 3) - 2;

            return fuel > 0 
                ? fuel 
                : 0;
        }
    }
}