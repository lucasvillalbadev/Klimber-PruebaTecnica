using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public TipoFormaGeometrica Tipo { get; internal set; }
        public decimal Lado { get; set; }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string TraducirForma(Idioma idioma, int cantidad);
    }
}
