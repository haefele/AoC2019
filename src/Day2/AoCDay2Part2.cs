using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2019.Day2
{
    public class AoCDay2Part2 : AoCDay
    {
        protected override AoCStatus Status => AoCStatus.WIP;

        protected override void Execute(string[] inputLines)
        {
            var program = inputLines.First().Split(',').Select(int.Parse).ToArray();

            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    var currentProgram = new List<int>(program).ToArray();
                    currentProgram[1] = noun;
                    currentProgram[2] = verb;

                    try 
                    {
                        var result = new AoCDay2Part1().RunProgram(currentProgram);
                        if (result == 19690720)
                            System.Console.WriteLine(100 * noun + verb);
                    }
                    catch (Exception e) when (e.Message.StartsWith("Invalid instruction"))
                    {
                        //next
                    }
                }
            }
        }
    }
}