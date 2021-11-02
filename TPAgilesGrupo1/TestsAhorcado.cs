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
        private int JugarIntentos(string[] intentos)
        {
            Ahorcado ahorcado = new Ahorcado();
            int intentosRestantes = 6;

            foreach (var intento in intentos)
            {
                intentosRestantes = ahorcado.Jugar(intento);
            }

            return intentosRestantes;
        }

        [TestMethod]
        public void TestJuegoPerfecto()
        {
            string [] intentos = { "M", "E","T","O","L","D","G","I","A","S" };

            Assert.IsTrue(JugarIntentos(intentos) == 6);
        }

        [TestMethod]
        public void TestJuegoParcialmenteCorrecto()
        {
            string[] intentos = { "M","Z", "E", "T", "W","O", "L", "D","N", "G", "I", "A", "S" };

            Assert.IsTrue(JugarIntentos(intentos) == 3);
        }

        [TestMethod]
        public void TestJuegoPerdido()
        {
            string[] intentos = { "Q", "Z", "U", "C", "W", "O", "V"};

            Assert.IsTrue(JugarIntentos(intentos) <= 0);
        }
    }
}
