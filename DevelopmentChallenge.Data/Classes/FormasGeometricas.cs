using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public static class FormasGeometricas
    {
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{ObtenerMensajeListaVacia(idioma)}</h1>");
                return sb.ToString();
            }

            sb.Append($"<h1>{ObtenerCabecera(idioma)}</h1>");

            List<GrupoFormaGeometrica> grupos = new List<GrupoFormaGeometrica>();
            GrupoFormaGeometrica grupoAux;

            foreach (FormaGeometrica forma in formas)
            {
                grupoAux = grupos.FirstOrDefault(g => g.Tipo == forma.Tipo);

                if(grupoAux == null)
                {
                    grupoAux = new GrupoFormaGeometrica(forma.Tipo);
                    grupos.Add(grupoAux);
                }
                
                grupoAux.AreaAcumulada += forma.CalcularArea();
                grupoAux.PerimetroAcumulado += forma.CalcularPerimetro();
                grupoAux.Formas.Add(forma);
            }

            foreach (GrupoFormaGeometrica grupo in grupos)
            {
                sb.Append(ObtenerLinea(grupo, idioma));
            }

            int cantidadTotal = grupos.Sum(g => g.Cantidad);
            decimal perimetroTotal = grupos.Sum(g => g.PerimetroAcumulado);
            decimal areaTotal = grupos.Sum(g => g.AreaAcumulada);

            sb.Append("TOTAL:<br/>");
            sb.Append(cantidadTotal + " " + ObtenerFormasDesc(idioma) + " ");
            sb.Append(ObtenerPerimetroDesc(idioma) + " " + perimetroTotal.ToString("#.##") + " ");
            sb.Append("Area " + areaTotal.ToString("#.##"));

            return sb.ToString();
        }

        private static string ObtenerMensajeListaVacia(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "Lista vacía de formas!";
                case Idioma.Ingles:
                    return "Empty list of shapes!";
                case Idioma.Italiano:
                    return "Elenco vuoto di forme!";
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
        private static string ObtenerCabecera(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "Reporte de formas";
                case Idioma.Ingles:
                    return "Shapes report";
                case Idioma.Italiano:
                    return "Rapporto sui moduli";
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
        private static string ObtenerAreaDesc(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                case Idioma.Ingles:
                case Idioma.Italiano:
                    return "Area";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
        private static string ObtenerPerimetroDesc(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                case Idioma.Italiano:
                    return "Perimetro";
                case Idioma.Ingles:
                    return "Perimeter";
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
        private static string ObtenerFormasDesc(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "formas";
                case Idioma.Ingles:
                    return "shapes";
                case Idioma.Italiano:
                    return "forme";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
                    break;
            }
        }
        private static string ObtenerLinea(GrupoFormaGeometrica grupo, Idioma idioma)
        {
            if (grupo.Cantidad > 0)
            {
                return $"{grupo.Cantidad} {grupo.TraducirForma(idioma)} | {ObtenerAreaDesc(idioma)} {grupo.AreaAcumulada:#.##} | {ObtenerPerimetroDesc(idioma)} {grupo.PerimetroAcumulado:#.##} <br/>";
            }

            return string.Empty;
        
        }

    }
}
