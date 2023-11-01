using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado)
        {
            this.Lado = lado;
            this.Tipo = Enums.TipoFormaGeometrica.Cuadrado;
        }

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return Lado * 4;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    break;
                case Idioma.Ingles:
                    return cantidad == 1 ? "Square" : "Squares";
                    break;
                case Idioma.Italiano:
                    return cantidad == 1 ? "Piazza" : "Piazze";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
    }
}
