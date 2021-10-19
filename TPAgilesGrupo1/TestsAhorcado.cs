using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TPAgilesGrupo1.Model;

namespace TestsAhorcado
{
    [TestClass]
    public class TestArriesgarPalabra
    {
        [TestMethod]
        public void TestIntentoVacio()
        {
            Ahorcado juego = new Ahorcado();

            Assert.IsFalse(juego.ValidarIntento(""));
        }

        [TestMethod]
        public void TestIntentoCorrecto()
        {
            Ahorcado juego = new Ahorcado();

            var intento = "METODOLOGIAS AGILES";

            Assert.IsTrue(juego.ValidarIntento(intento));
        }

        [TestMethod]
        public void TestIntentoMinusculasMayusculasCorrecto()
        {
            Ahorcado juego = new Ahorcado();

            var intento = "MetodOlOgias AgIlEs";

            Assert.IsTrue(juego.ValidarIntento(intento));
        }

        [TestMethod]
        public void TestIntentoIncorrecto()
        {
            Ahorcado juego = new Ahorcado();

            var intento = "SCRUM ES UNA METODOLOGIA AGIL";

            Assert.IsFalse(juego.ValidarIntento(intento));
        }
    }

    [TestClass]
    public class TestIngresoUsuarios
    {
        [TestMethod]
        public void TestIngresoNombreVacio()
        {
            Invitado invitado = new Invitado();

            var nombre = "";

            Assert.IsFalse(invitado.ValidarIngreso(nombre));
        }

        [TestMethod]
        public void TestIngresoNombreValido()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "juan";

            Assert.IsTrue(invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoCorto()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "sa";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreValidoConNumeros()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "pedr1to";

            Assert.IsTrue(invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoLargo()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "megustajugaralahorcado";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoCaracteres()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "!@#$%@";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoEspacio()
        {
            Invitado invitado = new Invitado();

            var nombreInvitado = "juan perez";

            Assert.IsTrue(!invitado.ValidarIngreso(nombreInvitado));
        }
    }

    [TestClass]
    public class TestsIngresarLetra
    {
        [TestMethod]
        public void TestIngresoLetraValida()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "a";

            Assert.IsTrue(ahorcado.ValidarIngresoLetra(letra));
        }

        [TestMethod]
        public void TestIngresoVacio()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "";

            Assert.IsFalse(ahorcado.ValidarIngresoLetra(letra));
        }

        [TestMethod]
        public void TestIngresoLetraMayusculaValida()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "A";

            Assert.IsTrue(ahorcado.ValidarIngresoLetra(letra));
        }

        [TestMethod]
        public void TestIngresoNumero()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "5";

            Assert.IsFalse(ahorcado.ValidarIngresoLetra(letra));
        }

        [TestMethod]
        public void TestIngresoCaracterNoAlfabetico()
        {
            Ahorcado ahorcado = new Ahorcado();

            var letra = "@";

            Assert.IsFalse(ahorcado.ValidarIngresoLetra(letra));
        }
    }

    [TestClass]
    public class TestsJuego
    {
        [TestMethod]
        public void TestJuegoPerfecto()
        {
            Ahorcado ahorcado = new Ahorcado();

            string [] intentos = { "M", "E","T","O","L","D","G","I","A","S" };

            int restanteLetras = 10;

            foreach (var intento in intentos)
            {
                ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(intento, "");

                if (intentos[intentos.Length-1] == intento)
                {
                    ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(" ", "");

                    restanteLetras = ahorcado.PalabraCorrecta.Length;
                }
            }

            Assert.IsTrue(restanteLetras == 0);
        }

        [TestMethod]
        public void TestJuegoParcialmenteCorrecto()
        {
            Ahorcado ahorcado = new Ahorcado();

            string[] intentos = { "M","Z", "E", "T", "W","O", "L", "D","N", "G", "I", "A", "S" };

            int restanteLetras = 10;

            ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(" ", "");

            foreach (var intento in intentos)
            {
                ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(intento, "");

                if (intentos[intentos.Length-1] == intento)
                {
                    ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(" ", "");

                    restanteLetras = ahorcado.PalabraCorrecta.Length;
                }
            }

            Assert.IsTrue(restanteLetras == 0);
        }

        [TestMethod]
        public void TestJuegoPerdido()
        {
            Ahorcado ahorcado = new Ahorcado();

            string[] intentos = { "Q", "Z", "U", "C", "W", "O", "V"};

            int restanteLetras = 10;

            foreach (var intento in intentos)
            {
                ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(intento, "");

                if (intentos[intentos.Length-1] == intento)
                {
                    ahorcado.PalabraCorrecta = ahorcado.PalabraCorrecta.Replace(" ", "");

                    restanteLetras = ahorcado.PalabraCorrecta.Length;
                }
            }

            Assert.IsFalse(restanteLetras == 0);
        }
    }
}
