using System.Globalization;
namespace Curso
{
    class Progam
    {
        public static void Main(string[] args)
        {
            aluno a1 = new aluno();
            System.Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine()!;
            System.Console.WriteLine("Digite as três notas do aluno: ");
            a1.Nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            a1.Nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            a1.Nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            System.Console.WriteLine("Nota final: " + a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (a1.NotaFinal() >= 60)
            {
                System.Console.WriteLine("APROVADO");
            }
            else
            {
                System.Console.WriteLine("REPROVADO");
                double flt = 60 - a1.NotaFinal();
                System.Console.WriteLine("Faltaram " + flt + " pontos");
            }
        }
    }
}