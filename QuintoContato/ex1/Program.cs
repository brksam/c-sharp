using System.Globalization;
namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            System.Console.WriteLine("Entre com os valores do retângulo(Largura primeiro): ");
            retangulo.largura = double.Parse(Console.ReadLine()! , CultureInfo.InvariantCulture);
            retangulo.altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            System.Console.WriteLine(retangulo);


        }
    }
}