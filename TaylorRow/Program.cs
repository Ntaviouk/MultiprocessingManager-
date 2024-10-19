using System;

class TaylorSeriesProcess
{
    static void Main(string[] args)
    {
        double A = double.Parse(args[0]);
        double B = double.Parse(args[1]);
        int steps = int.Parse(args[2]);

        double stepSize = (B - A) / steps;
        for (int i = 0; i < steps; i++)
        {
            double x = A + i * stepSize;
            double result = CalculateTaylorSeries(x);
            Console.WriteLine($"x = {x}, result = {result}");
        }
    }

    static double CalculateTaylorSeries(double x)
    {
        double sum = 0;
        for (int n = 0; n < 300000; n++)
        {
            double term = Math.Pow(-1, n) * (n + 1) * Math.Pow(x, n);
            sum += term;
        }
        return sum;
    }
}
