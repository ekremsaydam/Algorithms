using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Algorithms
    {
        public static double H(int N)
        {
            double sum = 0;
            for (int i = 1; i <= N; i++)
                sum += 1.0 / i;

            return sum;
        }

        public static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public static double sqrt(double c)
        {
            // Sqrt Newton
            if (c < 0.0) return Double.NaN;
            double err = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > err * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }

        public static Boolean IsPrime(int N)
        {
            if (N < 2) return false;
            for (int i = 2; i * i <= N; i++)
            {
                if (N % i == 0) return false;
            }

            return true;
        }

        public static int Abs(int x)
        {
            if (x < 0) return -x;
            else return x;
        }

        public static double Abs(double x)
        {
            if (x < 0.0) return -x;
            else return x;
        }
    }
}
