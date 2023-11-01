using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class GrupoFormaGeometrica
    {
        public TipoFormaGeometrica Tipo { get; set; }
        public List<FormaGeometrica> Formas { get; set; }
        public int Cantidad => Formas.Count;
        public decimal AreaAcumulada { get; set; }
        public decimal PerimetroAcumulado { get; set; }
        public GrupoFormaGeometrica(TipoFormaGeometrica tipo)
        {
            Tipo = tipo;
            AreaAcumulada= 0;
            PerimetroAcumulado= 0;
            Formas = new List<FormaGeometrica>();
        }

        public string TraducirForma(Idioma idioma) => Formas.Any() ? Formas.FirstOrDefault().TraducirForma(idioma, Cantidad) : "";
    }
}
