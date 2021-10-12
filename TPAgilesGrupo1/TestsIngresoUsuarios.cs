using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace TestsIngresoUsuarios
{
    [TestClass]
    public class TestIngresoUsuarios
    {
        [TestMethod]
        public void TestIngresoNombreVacio()
        {
            var nombreInvitado = "";

            Assert.AreEqual("", nombreInvitado);

            Console.WriteLine("Ingreso vacio, por favor ingrese un nombre valida");
        }

        [TestMethod]
        public void TestIngresoNombreValido()
        {
            var nombreInvitado = "juan";

            var validacionIngreso = ValidacionIngreso(nombreInvitado);

            Assert.IsTrue(validacionIngreso);

            if (validacionIngreso)
            {
                Console.WriteLine("El nombre ingresado es correcto, disfrute su juego");
            }
            else
            {
                Console.WriteLine("El nombre ingresado no es correcto, ingrese un nombre correcto (sin caracteres especiales y mayor o igual a 3 y menor a 20 caracteres)");
            }
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoCorto()
        {
            var nombreInvitado = "sa";

            var validacionIngreso = ValidacionIngreso(nombreInvitado);

            Assert.IsTrue(!validacionIngreso);

            if (!validacionIngreso)
            {
                Console.WriteLine("El nombre ingresado no es correcto, ingrese un nombre correcto (sin caracteres especiales y mayor o igual a 3 y menor a 20 caracteres)");
            }
            else
            {
                Console.WriteLine("El nombre ingresado es correcto, disfrute su juego");
            }
        }

        [TestMethod]
        public void TestIngresoNombreValidoConNumeros()
        {
            var nombreInvitado = "pedr1to";

            var validacionIngreso = ValidacionIngreso(nombreInvitado);

            Assert.IsTrue(validacionIngreso);

            if (validacionIngreso)
            {
                Console.WriteLine("El nombre ingresado es correcto, disfrute su juego");
            }
            else
            {
                Console.WriteLine("El nombre ingresado no es correcto, ingrese un nombre correcto (sin caracteres especiales y mayor o igual a 3 y menor a 20 caracteres)");
            }
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoLargo()
        {
            var nombreInvitado = "megustajugaralahorcado";

            var validacionIngreso = ValidacionIngreso(nombreInvitado);

            Assert.IsTrue(!validacionIngreso);

            if (!validacionIngreso)
            {
                Console.WriteLine("El nombre ingresado no es correcto, ingrese un nombre correcto (sin caracteres especiales y mayor o igual a 3 y menor a 20 caracteres)");
            }
            else
            {
                Console.WriteLine("El nombre ingresado es correcto, disfrute su juego");
            }
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoCaracteres()
        {
            var nombreInvitado = "!@#$%@";

            var validacionIngreso = ValidacionIngreso(nombreInvitado);

            Assert.IsTrue(!validacionIngreso);

            if (!validacionIngreso)
            {
                Console.WriteLine("El nombre ingresado no es correcto, ingrese un nombre correcto (sin caracteres especiales y mayor o igual a 3 y menor a 20 caracteres)");
            }
            else
            {
                Console.WriteLine("El nombre ingresado es correcto, disfrute su juego");
            }
        }

        [TestMethod]
        public void TestIngresoNombreInvalidoEspacio()
        {
            var nombreInvitado = "juan perez";

            var validacionIngreso = ValidacionIngreso(nombreInvitado);

            Assert.IsTrue(!validacionIngreso);

            if (!validacionIngreso)
            {
                Console.WriteLine("El nombre ingresado no es correcto, ingrese un nombre correcto (sin caracteres especiales y mayor o igual a 3 y menor a 20 caracteres)");
            }
            else
            {
                Console.WriteLine("El nombre ingresado es correcto, disfrute su juego");
            }
        }




        private bool ValidacionIngreso(string nombreIngresado)
        {
            var validate = false;

            if (nombreIngresado.Length > 2 && nombreIngresado.Length < 20)
            {
                Regex expresionRegular = new Regex(@"[a-zA-Z0-9]");

                var devolucion = expresionRegular.Matches(nombreIngresado);

                if (devolucion.Count == nombreIngresado.Length)
                {
                    validate = true;
                }
            }

            return validate;
        }
    }
}