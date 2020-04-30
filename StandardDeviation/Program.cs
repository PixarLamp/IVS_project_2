/*********************************************************************************
 * Project: Calculator
 * Date: 28.4.2020
 * Author: Peter Balážec <xbalaz12>
 * 
 * 
 *********************************************************************************
/**

/**
 * @file Program.cs
 * @author Peter Balazec
 * @date 28.4.2020
 */

using System;
using System.Collections.Generic;

namespace StandardDeviation
{
    public class Program
    {
        library.basic mathLab = new library.basic();

        /**
         * @brief Creates an array of numbers from a file
         * @return Array of numbers
         */
        static List<double> ReadFile()
        {
            
            List<double> numberArray = new List<double>();
            string number = Console.ReadLine(); ;
            while (number != null)
            {
                double newnum = double.Parse(number);
                numberArray.Add(newnum);
                number = Console.ReadLine();
            }

            return numberArray;
        }

        /**
         * @brief Calculates arithmetic mean
         * @param numberArray Array of Numbers
         * @return Arithmetic mean
         */
        public double ArithMean(List<double> numberArray)
        {
            double sumOfN = 0;
            int numCount = numberArray.Count;
            double mean;

            for (int i = 0; i < numCount; i++)
            {
                sumOfN = mathLab.add(sumOfN, numberArray[i]);

            }
            mean = mathLab.div(sumOfN, numCount);
            return mean;
        }

        /**
         * @brief Sum of all numbers in array squared
         * @param numberArray Array of numbers
         * @return Sum of numbers squared
         */
        public double SumOfNumSquared(List<double> numberArray)
        {
            double sumOfN2 = 0;
            int numCount = numberArray.Count;
            for (int i = 0; i < numCount; i++)
            {
                double n2 = mathLab.exp(numberArray[i], 2);
                sumOfN2 = mathLab.add(sumOfN2, n2);
            }
            return sumOfN2;
        }

        /**
         * @brief Calculated Standard Deviation 
         * @param numberArray Array of numbers
         * @return The result of calculating Standard Deviation
         */
        public double StdDevCalculation(List<double> numberArray)
        {
            int numCount = numberArray.Count;
            double sum = SumOfNumSquared(numberArray);
            double mean2 = mathLab.exp(ArithMean(numberArray), 2);
            double bracket = sum - (numCount * mean2);
            double stddev = mathLab.root(bracket / (numCount - 1), 2);

            return stddev;
        }

        /**
         * @brief Creates an array of random numbers
         * @param count Amount of numbers in array
         * @return Array of random numbers
         */
        static List<double> RandomNumbers(int count)
        {
            List<double> numberArray = new List<double>();
            Random random = new Random();
            int maxNum = 1000;
            for (int i = 0; i < count; i++)
            {
                int num = random.Next(maxNum);
                double ran = random.NextDouble();
                numberArray.Add(num * ran);
            }
                return numberArray;
        }

        static void Main(string[] args)
        {
            
            Program s = new Program();

            List<double> numberArray;

            numberArray = ReadFile();

            //numberArray = RandomNumbers(10);
            //numberArray = RandomNumbers(100);
            //numberArray = RandomNumbers(1000);

            double stddev = s.StdDevCalculation(numberArray);
            Console.Write(stddev);

            Console.ReadLine();
            
        }
    }
}