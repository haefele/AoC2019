using System.Linq;

namespace AoC2019.Day1
{
    public class AoCDay1Part1 : AoCDay
    {
        protected override AoCStatus Status => AoCStatus.Done;

        protected override void Execute(string[] inputLines)
        {
            var result = inputLines
                .Select(int.Parse)
                .Select(this.CalculateFuel)
                .Sum();

            System.Console.WriteLine(result);
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