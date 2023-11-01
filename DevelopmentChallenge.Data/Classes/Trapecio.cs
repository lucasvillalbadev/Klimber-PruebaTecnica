using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public decimal ladoSuperior { get; set; }
        public decimal ladoInferior { get; set; }
        public decimal Alto { get; set; }

        public Trapecio(decimal ladoSuperior, decimal ladoInferior, decimal lado, decimal alto)
        {
            this.Tipo = Enums.TipoFormaGeometrica.Trapecio;
            this.ladoSuperior = ladoSuperior;
            this.ladoInferior = ladoInferior;
            this.Lado= lado;
            this.Alto = alto;
        }

        public override decimal CalcularArea()
        {
            return (ladoSuperior + ladoInferior) / 2 * Alto;
        }

        public override decimal CalcularPerimetro()
        {
            return ladoSuperior + ladoInferior + (Lado * 2);
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                    break;
                case Idioma.Ingles:
                    return cantidad == 1 ? "Trapeze" : "Trapezoids";
                    break;
                case Idioma.Italiano:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
    }
}
