using System;
using System.Globalization;

namespace Course {
    class ex2 {
        
        public static void Run(){
            System.Console.WriteLine("Entre com seu nome completo: \n");
            string name = Console.ReadLine() ?? "";
            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine() ?? "0");
            System.Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            System.Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] v = (Console.ReadLine() ?? "").Split(" ");
            string nomeVetor = v[0];
            int idadeVetor = int.Parse(v[1], CultureInfo.InvariantCulture);
            double alturaVetor = double.Parse(v[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine("-------SAÍDA--------");
            System.Console.WriteLine($"{name}");
            System.Console.WriteLine($"{quartos}");
            System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine($"{nomeVetor}");
            System.Console.WriteLine($"{idadeVetor}");
            System.Console.WriteLine(alturaVetor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

