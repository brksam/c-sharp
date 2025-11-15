using System;
using System.Globalization;

namespace Course {
    class ex1 {
        public static void Run(){
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codido = 5290;
            char genero = 'M'; 

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //fiz td em uma linha pra testar todos os tipos 
            System.Console.WriteLine($"Produtos: \n{produto1}, cujo o preço é $ {preco1:F2}\n{produto2}, cujo o preço é {preco2:F2} \n\nRegistro: {idade} anos de idade, código {codido} e gênero: {genero}\n\nMedida com oito casas decimais: {medida:F8}\nArredondado (três casas decimais): {medida:F3}\nSeparador decimal invariante culture: " + medida.ToString("F3",CultureInfo.InvariantCulture));
        
        }
    }
}