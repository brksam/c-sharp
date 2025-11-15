using System;
using System.Globalization;

namespace Course {
    class ex3 {
        public static void Run(){
            int N = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < N; i++){
                string[] v = (Console.ReadLine() ?? "").Split(" ");
                double a = double.Parse(v[0], CultureInfo.InvariantCulture);
                double b = double.Parse(v[1], CultureInfo.InvariantCulture);
                double c = double.Parse(v[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
