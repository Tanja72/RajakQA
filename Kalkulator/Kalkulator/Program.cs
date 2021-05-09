using System;


namespace Kalkulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double rezultat = 0;
            string operacija;
            double a = 0, b = 0;

            operacija = Input.GetStringInput("Unesite operaciju: ");
            a = Convert.ToDouble(Input.GetStringInput("Prvi operand: "));
            b = Convert.ToDouble(Input.GetStringInput("Drugi operand: "));

            switch (operacija)
            {
                case "+":
                    rezultat = Aritmetika.Zbir(a, b);
                    break;
                case "-":
                    rezultat = Aritmetika.Razlika(a, b);
                    break;
                case "*":
                    rezultat = Aritmetika.Proizvod(a, b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Operand nije validan. Zabranjeno je deliti nulom!");
                        return;
                    }
                    rezultat = Aritmetika.Kolicnik(a, b);
                    break;
                default:
                    Console.WriteLine("\nOperacija nije validna.");
                    return;
            }

            Console.WriteLine("Rezultat je: " + rezultat);
        }
    }
}
