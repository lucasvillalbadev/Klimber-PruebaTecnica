using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado)
        {
            this.Lado = lado;
            this.Tipo = Enums.TipoFormaGeometrica.Circulo;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                    break;
                case Idioma.Ingles:
                    return cantidad == 1 ? "Circle" : "Circles";
                    break;
                case Idioma.Italiano:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
    }
}
