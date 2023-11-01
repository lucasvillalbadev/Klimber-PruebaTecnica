using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Enums
{
    public enum Idioma
    {
        [Display(Name = "Castellano")]
        Castellano = 1,
        [Display(Name = "Inglés")]
        Ingles = 2,
        [Display(Name = "Italiano")]
        Italiano = 3,
    }
}
