namespace Course {
    class ex5 {
        public static void Run(){
            string[] v = (Console.ReadLine() ?? "").Split(" ");
            int numero1 = int.Parse(v[0]);
            int numero2 = int.Parse(v[1]);
            if (numero1 % numero2 == 0 || numero2 % numero1 == 0 ){
                System.Console.WriteLine("Sao Multiplos");
            }
            else {
                System.Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}