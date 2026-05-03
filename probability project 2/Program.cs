using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers: ");
        int n = int.Parse(Console.ReadLine());
        double[] data = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            data[i] = double.Parse(Console.ReadLine());
        }

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

        double q1 = data[(int)(0.25 * n)];
        double q3 = data[(int)(0.75 * n)];
        double iqr = q3 - q1;

        double lowerBound = q1 - (1.5 * iqr);
        double upperBound = q3 + (1.5 * iqr);

        Console.WriteLine("\nLower Bound: " + lowerBound);
        Console.WriteLine("Upper Bound: " + upperBound);
        Console.WriteLine("--- Outliers Check ---");

        for (int i = 0; i < n; i++)
        {
            if (data[i] < lowerBound || data[i] > upperBound)
            {
                Console.WriteLine(data[i] + " is an Outlier");
            }
            else
            {
                Console.WriteLine(data[i] + " is Normal");
            }
        }
    }
}