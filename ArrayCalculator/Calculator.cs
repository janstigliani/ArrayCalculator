using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCalculator
{
    public class Calculator
    {
        private double[] Numbers;
        public Calculator(string numberString)
        {
            var stringArray = numberString.Split(" ");
            Numbers = new double[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                //numbers[i] = double.Parse(stringArray[i]);

                Numbers[i] = double.TryParse(stringArray[i], out double result) ? result : 0;
            }

        }

        public double Sum()
        {
            double sum = 0;

            foreach (var number in Numbers)
            {
                sum += number;
            }
            return (Math.Round(sum*10))/10;
        }

        public double Avg()
        {
            double sum = 0;

            foreach (var number in Numbers)
            {
                sum += number;
            }

            return (Math.Round((sum / Numbers.Length)*10))/10;
        }

        public double Max()
        {
            return Numbers.Max();
        }

    }
}
