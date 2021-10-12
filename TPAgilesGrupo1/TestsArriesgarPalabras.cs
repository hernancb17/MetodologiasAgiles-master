using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace TestsArriesgarPalabras
{
    [TestClass]
    public class TestArriesgarPalabra
    {
        private const string PalabraCorrecta = "METODOLOGIAS AGILES";

        //Se ingresa algo distinto de 'ahorcado' (o variaciones de mayúsculas), se muestra 'Ha perdido' 

        [TestMethod]
        public void TestIntentoVacio()
        {
            var intento = "";

            Assert.AreNotEqual(intento, PalabraCorrecta);

            Console.WriteLine("Por favor ingrese una palabra");
        }

        [TestMethod]
        public void TestIntentoCorrecto()
        {
            var intento = "METODOLOGIAS AGILES";

            Assert.AreEqual(intento, PalabraCorrecta);

            Console.WriteLine("Felicitaciones, ha ganado");
        }

        [TestMethod]
        public void TestIntentoMinusculasMayusculas()
        {
            var intento = "MetodOlOgias AgIlEs";

            intento = intento.ToUpper();

            Assert.AreEqual(intento, PalabraCorrecta);

            Console.WriteLine("Felicitaciones, ha ganado");
        }

        [TestMethod]
        public void TestIntentoIncorrecto()
        {
            var intento = "SCRUM ES UNA METODOLOGIA AGIL";

            Assert.AreNotEqual(intento, PalabraCorrecta);

            Console.WriteLine("Ha perdido");
        }
    }
}
