using System;
using System.Globalization;
namespace Curso {
    public class Retangulo {
        public double largura;
        public double altura;
        public double Area()
        {
            return altura * largura;
        }
        public double Perimetro()
        {
            return 2 * (altura + largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
            
        }
        public override string ToString()
        {
            return "AREA: " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "PERÍMETRO: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "DIAGONAL: "  + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}