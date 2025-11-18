namespace Curso
{
    class Dolar
    {
        public static double IOF = 6.0;

        public static double DolarConvertido(double qt, double cota)
        {
            double total = qt * cota;
            return total + total * IOF / 100.0;
        }
       
    }
}