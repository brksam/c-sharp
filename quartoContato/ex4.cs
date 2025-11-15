using System;

namespace Course {
    class ex4 {
        public static void Run() {

            int N = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < N; i++) {

                string[] v = (Console.ReadLine() ?? "").Split(" ");

                double a = double.Parse(v[0]);
                double b = double.Parse(v[1]);

                if (b == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double r = a / b;
                    Console.WriteLine(r.ToString("F1"));
                }
            }
        }
    }
}
