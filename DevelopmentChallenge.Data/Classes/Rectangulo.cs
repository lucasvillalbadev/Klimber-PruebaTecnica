using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal Alto { get; set; }
        public Rectangulo(decimal lado, decimal alto) 
        {
            this.Tipo = TipoFormaGeometrica.Rectangulo;
            this.Alto = alto;
            this.Lado= lado;
        }
        public override decimal CalcularArea()
        {
            return Alto * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return (Alto + Lado) * 2;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Rectángulo" : "Rectángulos";
                    break;
                case Idioma.Ingles:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                    break;
                case Idioma.Italiano:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
    }
}
