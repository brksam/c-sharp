namespace Course {
    class ex9 {
        public static void Run(){
            string[] v = (Console.ReadLine() ?? "").Split(" ");
            float x = float.Parse(v[0]);
            float y = float.Parse(v[1]);

            if(x < 0 && y < 0){
                System.Console.WriteLine("Q3");
            }
            else if(x > 0 && y > 0){
                System.Console.WriteLine("Q1");
            }
            else if(x > 0 && y < 0){
                System.Console.WriteLine("Q4");
            }
            else if(x < 0 && y > 0){
                System.Console.WriteLine("Q2");
            }
            else if (x == 0 && y == 0) {
                System.Console.WriteLine("Origem");
            }
            else{
                System.Console.WriteLine("nao vai cair aqui");
            }
        }
    }
}