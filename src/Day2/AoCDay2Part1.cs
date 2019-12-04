using System.Linq;

namespace AoC2019.Day2
{
    public class AoCDay2Part1 : AoCDay
    {
        protected override AoCStatus Status => AoCStatus.Done;

        protected override void Execute(string[] inputLines)
        {
            var program = inputLines.First().Split(',').Select(int.Parse).ToArray();
            
            program[1] = 12;
            program[2] = 2;
            
            var result = this.RunProgram(program);
            System.Console.WriteLine(result);
        }

        public int RunProgram(int[] program)
        {
            bool cancel = false;
            int currentLocation = 0;
            while (currentLocation <= program.Length && cancel == false)
            {
                var instruction = program[currentLocation];

                switch (instruction)
                {
                    case 1:
                    {

                        var input1Pos = program[currentLocation + 1];
                        var input2Pos = program[currentLocation + 2];
                        var outputPos = program[currentLocation + 3];
                        
                        program[outputPos] = program[input1Pos] + program[input2Pos];

                        currentLocation += 4;
                        break;
                    }
                    case 2:
                    {

                        var input1Pos = program[currentLocation + 1];
                        var input2Pos = program[currentLocation + 2];
                        var outputPos = program[currentLocation + 3];
                        
                        program[outputPos] = program[input1Pos] * program[input2Pos];

                        currentLocation += 4;
                        break;
                    }
                    case 99:
                    {
                        cancel = true;
                        break;
                    }
                    default:
                    {
                        throw new System.Exception($"Invalid instruction {instruction}");
                    }
                }
            }

            return program[0];
        }
    }
}