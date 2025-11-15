namespace Course {
    class ex03 {
        public static void Run(){
            int numero = int.Parse(Console.ReadLine() ?? "");
            if (numero >= 0) {
                System.Console.WriteLine("NAO NEGATIVO");
            }
            else if(numero < 0) {
                System.Console.WriteLine("NEGATIVO");
            }
        }
    }
}