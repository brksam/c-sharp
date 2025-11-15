using System;

namespace Course {
    class ex5 {
        public static void Run() {

            int N = int.Parse(Console.ReadLine() ?? "0");
            int fat = 1;

            for (int i = 1; i <= N; i++) {
                fat *= i;
            }

            Console.WriteLine(fat);
        }
    }
}
