namespace Course {
    class ex4 {
        public static void Run(){
            System.Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine() ?? "");
            if(numero % 2 == 0){
                System.Console.WriteLine("PAR");
            }
            else {
                System.Console.WriteLine("IMPAR");
            }
        }
    }
}