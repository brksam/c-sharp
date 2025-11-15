namespace Course {
    class ex8 {
        public static void Run(){
            double valor = double.Parse(Console.ReadLine() ?? "");
            if(valor >= 0 && valor <= 25.00){
                System.Console.WriteLine("Intervalo (0,25)");
            }
            else if(valor > 25 && valor <= 50.00){
                System.Console.WriteLine("Intervalo (25,50)");                
            }
            else if(valor > 50 && valor <= 75.00){
                System.Console.WriteLine("Intervalo (50,75)");                
            }
            else if(valor > 75 && valor <= 100.00){
                System.Console.WriteLine("Intervalo (75,100)");  
            }
            else {
                System.Console.WriteLine("FORA DO INTERVALO");
            }
        }
    }
}