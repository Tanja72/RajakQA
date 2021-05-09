using System;


namespace Kalkulator
{
    public class Aritmetika
    {
        public static double Zbir(double a, double b)
        {
            double rezultat = 0;

            rezultat = a + b;

            return rezultat;
        }

        public static double Razlika(double a, double b)
        {
            double rezultat = 0;

            rezultat = a - b;

            return rezultat;
        }

        public static double Proizvod(double a, double b)
        {
            double rezultat = 0;

            rezultat = a * b;

            return rezultat;
        }

        public static double Kolicnik(double a, double b)
        {
            double rezultat = 0;

            if (b == 0)
            {
                return 0;
            }

            rezultat = a / b;

            return rezultat;
        }
    }
}
