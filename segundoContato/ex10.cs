using System;
using System.Globalization;

namespace Course {
    class ex10 {

        public static void Run() {

            double salario = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if (salario <= 2000.0) {
                Console.WriteLine("Isento");
                return;
            }
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                imposto = (1000.0 * 0.08) + (salario - 3000.0) * 0.18;
            }
            else {
                imposto = (1000.0 * 0.08) + (1500.0 * 0.18) + (salario - 4500.0) * 0.28;
            }

            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
