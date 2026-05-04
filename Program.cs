using System;

class Program
{
    static void Main()
    {
        double[] data = { 115, 182, 191, 31, 196, 1099, 5, 172, 10, 179, 83, 21, 20, 21, 186, 177, 195, 193, 188, 199, 62, 109, 105, 183, 110 };
        int n = data.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (data[i] > data[j])
                {
                    double temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += data[i];
        }
        double mean = sum / n;

        double mode = data[0];
        int maxCount = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (data[j] == data[i]) count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                mode = data[i];
            }
        }

        double median;
        if (n % 2 == 0)
            median = (data[n / 2 - 1] + data[n / 2]) / 2;
        else
            median = data[n / 2];

        double varianceSum = 0;
        for (int i = 0; i < n; i++)
        {
            varianceSum += (data[i] - mean) * (data[i] - mean);
        }
        double variance = varianceSum / n;

        double p20 = data[(int)(0.20 * n)];
        double p50 = median;
        double q3 = data[(int)(0.75 * n)];
        double q2 = median;
        double q1 = data[(int)(0.25 * n)];

        double range = data[n - 1] - data[0];
        double iqr = q3 - q1;
        double stdDev = Math.Sqrt(variance);

        double sumDev = 0;
        for (int i = 0; i < n; i++)
        {
            sumDev += (data[i] - mean);
        }

        Console.WriteLine("Mean: " + mean);
        Console.WriteLine("Mode: " + mode);
        Console.WriteLine("Median: " + median);
        Console.WriteLine("Variance: " + variance);
        Console.WriteLine("P20: " + p20);
        Console.WriteLine("P50: " + p50);
        Console.WriteLine("Third Quartile: " + q3);
        Console.WriteLine("Second Quartile: " + q2);
        Console.WriteLine("Range: " + range);
        Console.WriteLine("Interquartile Range: " + iqr);
        Console.WriteLine("Standard Deviation: " + stdDev);
        Console.WriteLine("Summation of Deviations: " + sumDev);
    }
}