using System;

namespace Course {
    class ex2 {
        public static void Run(){
            int N = int.Parse(Console.ReadLine() ?? "0");

            int dentro = 0;
            int fora = 0;

            for(int i = 0; i < N; i++){
                int x = int.Parse(Console.ReadLine() ?? "0");

                if(x >= 10 && x <= 20){
                    dentro++;
                }
                else{
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
