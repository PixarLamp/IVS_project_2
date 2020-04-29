using System;
using System.Collections.Generic;


namespace StandardDeviation
{
	public class Program
	{
		library.basic mathLab = new library.basic();

		static List<double> GetInput()
		{
			List<double> numberArray = new List<double>();
			string number;
			while ((number = Console.ReadLine()) != null)
			{
				double newnum = double.Parse(number);
				numberArray.Add(newnum);
			}
			return numberArray;
		}

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
		public double StdDevCalculation(List<double> numberArray)
		{
			int numCount = numberArray.Count;
			double sum = SumOfNumSquared(numberArray);
			double mean2 = mathLab.exp(ArithMean(numberArray), 2);
			double bracket = sum - (numCount * mean2);
			double stddev = mathLab.root(bracket / (numCount - 1), 2);

			return stddev;
		}
		static void Main(string[] args)
		{
			List<double> numberArray = GetInput();
			double stddev = StdDevCalculation(numberArray);
			Console.WriteLine("Standard Deviation result: {0}", stddev);
			Console.Read();
		}
	}
}