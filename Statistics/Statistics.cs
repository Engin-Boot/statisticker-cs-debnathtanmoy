using System;
using System.Collections.Generic;
using System.Linq;
using static Statistics.Stats;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            Stats compute = new Stats();
            if(numbers.Count == 0)
            {
                compute.average = Double.NaN;
                compute.max = Double.NaN;
                compute.min = Double.NaN;

            }
            else
            {
                compute.average = numbers.Average();
                compute.min = numbers.Max();
                compute.max = numbers.Min();
            }
            return compute;
        }
    }
}
