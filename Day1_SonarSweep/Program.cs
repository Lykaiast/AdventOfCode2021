using System;
using System.IO;
using System.Reflection;

namespace Day1_SonarSweep
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstPart();
            SecondPart();
        }

        public static void FirstPart()
        {
            string[] measurementsString = File.ReadAllLines(@"C:\Users\maria\source\repos\AdventOfCode2021\Day1_SonarSweep\measurements.txt");
            int[] measurements = Array.ConvertAll(measurementsString, s => int.Parse(s));
            int previousMeasurement = measurements[0];
            int depthIncreases = 0;

            foreach (int m in measurements)
            {
                if (previousMeasurement < m)
                {
                    depthIncreases++;
                }

                previousMeasurement = m;
            }

            Console.WriteLine("Number of increases: " + depthIncreases);
        }

        public static void SecondPart()
        {
            string[] measurementsString = File.ReadAllLines(@"C:\Users\maria\source\repos\AdventOfCode2021\Day1_SonarSweep\measurements.txt");
            int[] measurements = Array.ConvertAll(measurementsString, s => int.Parse(s));
            int depthThreeIncreases = 0;

            for (int i = 0; i < measurements.Length; i++)
            {
                try
                {
                    int A = measurements[i] + measurements[i + 1] + measurements[i + 2];
                    int B = measurements[i + 1] + measurements[i + 2] + measurements[i + 3];
                    if (B > A)
                    {
                        depthThreeIncreases++;
                    }
                }
                catch (Exception e)
                {
                    break;
                }
            }

            Console.WriteLine("Number of three-sum increases: " + depthThreeIncreases);
        }
    }
}
