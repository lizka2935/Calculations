namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int consultationTime = 30;
            TimeSpan[] startTimes = { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 30, 00), new TimeSpan(16, 50, 00) };
            int[] durations = { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            TimeSpan interval;
            interval = new TimeSpan(0, consultationTime, 0);



            int u = 0;

            for (var i = beginWorkingTime; i < endWorkingTime; i += interval)
            {

                if (u <= startTimes.Length - 1 && startTimes[u] == i)
                {
                    i += new TimeSpan(0, durations[u], 0);

                    u++;

                    if (u <= startTimes.Length - 1 && startTimes[u] == i)
                    {
                        i += new TimeSpan(0, durations[u], 0);
                        u++;
                    }
                    if (u <= startTimes.Length - 1 && startTimes[u] - i < interval)
                    {
                        i = startTimes[u] + new TimeSpan(0, durations[u], 0);
                        u++;
                    }

                }
                if (i < startTimes[startTimes.Length - 1] && u <= startTimes.Length - 1 && startTimes[u] - i < interval)
                {
                    i = startTimes[u] + new TimeSpan(0, durations[u], 0);
                    u++;
                }
                Console.WriteLine(i);
            }
        }
    }
}
 