using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taschenrechner liest in UPN 2 Operanden und 1 Operator (Grundrechenarten) ein und gibt das Ergebnis aus.

            double operand1, operand2, ergebnis = 0.0;
            string str_operand1, str_operand2, str_operator;
            bool ungueltigeEingabe = false;

            Console.WriteLine("Dieser Taschenrechner liest 2 Gleitkommazahlen als Operanden sowie einen Operator (+-*/) ein und berechnet das Ergebnis.\n");

            Console.Write("- Gib den 1. Operanden ein: ");
            str_operand1 = Console.ReadLine(); operand1 = Convert.ToDouble(str_operand1);
            Console.Write("- Gib den 2. Operanden ein: ");
            str_operand2 = Console.ReadLine(); operand2 = Convert.ToDouble(str_operand2);

            Console.Write("- Gib einen der Operatoren '+ - * /' ein: ");
            str_operator = Console.ReadLine();

            switch (str_operator)
            {
                case "+":
                    ergebnis = operand1 + operand2;
                    break;
                case "-":
                    ergebnis = operand1 - operand2;
                    break;
                case "*":
                    ergebnis = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                        ungueltigeEingabe = true;
                    else
                        ergebnis = operand1 / operand2;
                    break;
                default:
                    ungueltigeEingabe = true;
                    break;
            }

            Console.Write("\nDas Ergebnis lautet: ");
            if (ungueltigeEingabe)
                Console.WriteLine("ungültige Eingabe!");
            else
                Console.WriteLine(ergebnis);
            Console.ReadLine();
        }
    }
}
