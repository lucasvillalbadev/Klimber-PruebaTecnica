using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormasGeometricas.Imprimir(new List<FormaGeometrica>(), Enums.Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormasGeometricas.Imprimir(new List<FormaGeometrica>(), Enums.Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormasGeometricas.Imprimir(new List<FormaGeometrica>(), Enums.Idioma.Italiano));
        }

        [TestCase(TipoFormaGeometrica.Circulo)]
        [TestCase(TipoFormaGeometrica.Rectangulo)]
        [TestCase(TipoFormaGeometrica.Trapecio)]
        [TestCase(TipoFormaGeometrica.TrianguloEquilatero)]
        [TestCase(TipoFormaGeometrica.Cuadrado)]
        public void TestResumenListaConUnaForma(TipoFormaGeometrica forma)
        {
            var formas = new List<FormaGeometrica>();
            string resultadoEsperado = "";
            switch (forma)
            {
                case TipoFormaGeometrica.Cuadrado:
                    formas.Add(new Cuadrado(5));
                    resultadoEsperado = "<h1>Reporte de formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25";
                    break;
                case TipoFormaGeometrica.TrianguloEquilatero:
                    formas.Add(new TrianguloEquilatero(5));
                    resultadoEsperado = "<h1>Reporte de formas</h1>1 Triángulo | Area 10,83 | Perimetro 15 <br/>TOTAL:<br/>1 formas Perimetro 15 Area 10,83";
                    break;
                case TipoFormaGeometrica.Circulo:
                    formas.Add(new Circulo(5));
                    resultadoEsperado = "<h1>Reporte de formas</h1>1 Círculo | Area 19,63 | Perimetro 15,71 <br/>TOTAL:<br/>1 formas Perimetro 15,71 Area 19,63";
                    break;
                case TipoFormaGeometrica.Trapecio:
                    formas.Add(new Trapecio(2, 4, 3, 2));
                    resultadoEsperado = "<h1>Reporte de formas</h1>1 Trapecio | Area 6 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 6";
                    break;
                case TipoFormaGeometrica.Rectangulo:
                    formas.Add(new Rectangulo(2, 4));
                    resultadoEsperado = "<h1>Reporte de formas</h1>1 Rectángulo | Area 8 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 8";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
                    break;
            }

            var resumen = FormasGeometricas.Imprimir(formas, Enums.Idioma.Castellano);
            //Se cambio "Reporte de Formas" a "Reporte de formas" para que coincida con el mismo formato en inglés
            Assert.AreEqual(resultadoEsperado, resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormasGeometricas.Imprimir(cuadrados, Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormasGeometricas.Imprimir(formas, Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormasGeometricas.Imprimir(formas, Idioma.Castellano);
            //Se cambio "Reporte de Formas" a "Reporte de formas" para que coincida con el mismo formato en inglés
            Assert.AreEqual(
                "<h1>Reporte de formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
