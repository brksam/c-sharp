using System;

namespace Course {
    class ex6 {
        public static void Run() {

            int N = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 1; i <= N; i++) {
                if (N % i == 0) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
