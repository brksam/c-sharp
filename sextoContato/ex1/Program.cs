using System.Globalization;

namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Digite a cotação do Dolar: ");
            double cota = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            System.Console.Write("Quantos Dólares você vai comprar: ");
            double qt = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double resultado = Dolar.DolarConvertido(qt, cota);

            System.Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}