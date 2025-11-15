using System.Globalization;
namespace Course {
    class ex7 {
        public static void Run(){
            float precoCachorroQuente = 4.00F;
            float precoXSalada = 4.50F;
            float precoXBacon = 5.00F;
            float precoTorradaSimples = 2.00F;
            float precoRefrigerante = 1.50F;

            System.Console.WriteLine("----TABELA----");
            System.Console.WriteLine("1 - Cachorro Quente - R$ 4.00");
            System.Console.WriteLine("2 - X-Salada - R$ 4.50");
            System.Console.WriteLine("3 - X-Bacon - R$ 5.00");
            System.Console.WriteLine("4 - Torrada Simples - R$ 2.00");
            System.Console.WriteLine("5 - Refrigerante - R$ 1.50");
            System.Console.WriteLine("----TABELA----");
            string[] v = (Console.ReadLine() ?? "").Split(" ");
            int escolha1 = int.Parse(v[0]);
            int escolha2 = int.Parse(v[1]);
            
            float escolhaReal1 = 0;

            if (escolha1 == 1){
                escolhaReal1 = precoCachorroQuente;
            }
            else if(escolha1 == 2){
                escolhaReal1 = precoXSalada;
            }
            else if(escolha1 == 3){
                escolhaReal1 = precoXBacon;
            }
            else if(escolha1 == 4){
                escolhaReal1 = precoTorradaSimples;
            }
            else if(escolha1 == 5){
                escolhaReal1 = precoRefrigerante;
            }

            float valor = escolhaReal1 * escolha2;

            System.Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
