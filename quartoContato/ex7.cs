using System;

namespace Course {
    class ex7 {
        public static void Run() {

            int N = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 1; i <= N; i++) {

                int quad = i * i;
                int cubo = quad * i;

                Console.WriteLine($"{i} {quad} {cubo}");
            }

        }
    }
}
