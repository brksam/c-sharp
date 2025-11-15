using System;

namespace Course {
    class ex1 {
        public static void Run(){
            int valor = int.Parse(Console.ReadLine() ?? "");         
            while (valor != 2002){
                System.Console.WriteLine("Senha Invalida");
                valor = int.Parse(Console.ReadLine() ?? "");
            }   
            System.Console.WriteLine("Acesso Permitido");           
        }
    }
}