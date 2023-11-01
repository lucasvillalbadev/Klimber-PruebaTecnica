using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado)
        {
            this.Lado = lado;
            this.Tipo = Enums.TipoFormaGeometrica.TrianguloEquilatero;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 3;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                    break;
                case Idioma.Ingles:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                    break;
                case Idioma.Italiano:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
    }
}
