using System;
using System.IO;

namespace Day2_Dive
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstPart();
            SecondPart();
        }

        private static void FirstPart()
        {
            int verticalPosition = 0;
            int horizontalPosition = 0;

            string[] movementsString = File.ReadAllLines(@"C:\Users\maria\source\repos\AdventOfCode2021\Day2_Dive\movements.txt");

            foreach (string movement in movementsString)
            {
                string instruction = movement.Split(' ')[0];
                int instructionValue = int.Parse(movement.Split(' ')[1]);

                switch (instruction)
                {
                    case "down":
                        verticalPosition -= instructionValue;
                        break;
                    case "up":
                        verticalPosition += instructionValue;
                        break;
                    default:
                        horizontalPosition += instructionValue;
                        break;
                }
            }

            Console.WriteLine("The result is " + Math.Abs(verticalPosition * horizontalPosition));
        }

        private static void SecondPart()
        {
            int verticalPosition = 0;
            int horizontalPosition = 0;
            int aim = 0;

            string[] movementsString = File.ReadAllLines(@"C:\Users\maria\source\repos\AdventOfCode2021\Day2_Dive\movements.txt");

            foreach (string movement in movementsString)
            {
                string instruction = movement.Split(' ')[0];
                int instructionValue = int.Parse(movement.Split(' ')[1]);

                switch (instruction)
                {
                    case "down":
                        aim += instructionValue;
                        break;
                    case "up":
                        aim -= instructionValue;
                        break;
                    default:
                        horizontalPosition += instructionValue;
                        verticalPosition += aim * instructionValue;
                        break;
                }
            }

            Console.WriteLine("The result is " + Math.Abs(verticalPosition * horizontalPosition));
        }
    }
}
