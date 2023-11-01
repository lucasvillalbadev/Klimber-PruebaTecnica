using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DevelopmentChallenge.Data.Enums
{
    public enum TipoFormaGeometrica
    {
        [Display(Name = "Cuadrado")]
        Cuadrado = 1,
        [Display(Name = "Triángulo")]
        TrianguloEquilatero = 2,
        [Display(Name = "Círculo")]
        Circulo = 3,
        [Display(Name = "Trapecio")]
        Trapecio = 4,
        [Display(Name = "Rectángulo")]
        Rectangulo = 5,
    }
}
