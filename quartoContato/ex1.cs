using System;

namespace Course {
    class ex1 {
        public static void Run(){
            int X = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 1; i <= X; i++){
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
