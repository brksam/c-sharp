using System.Globalization;
namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {

            Funcionario f1 = new Funcionario();

            System.Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            System.Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            System.Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            System.Console.WriteLine("Fucionário: " + f1.Nome + ", $ " + f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            double p = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            f1.AumentaSalario(p);

            System.Console.WriteLine("Dados atualizados: " + f1.Nome + ", $" + f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}