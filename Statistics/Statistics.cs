using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            Stats compute = new Stats();
            if(numbers.Count == 0)
            {
                compute.average = double.NaN;
                compute.max = double.NaN;
                compute.min = double.NaN;

            }
            else
            {
                compute.average = numbers.Average();
                compute.max = numbers.Min();
                compute.min = numbers.Max();
            }
            return compute;
        }
    }
}
