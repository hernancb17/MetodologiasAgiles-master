using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TPAgilesGrupo1.Model;

namespace TPAgilesGrupo1.Tests
{
    [TestClass]
    public class TestsUsuario
    {
        [TestMethod]
        public void TestIngresoMailVacio()
        {
            Usuario usuario = new Usuario();

            var mail = "";

            Assert.IsFalse(usuario.ValidarMail(mail));
        }

        [TestMethod]
        public void TestIngresoMailSinArroba()
        {
            Usuario usuario = new Usuario();

            var mail = "mail.com";

            Assert.IsFalse(usuario.ValidarMail(mail));
        }

        [TestMethod]
        public void TestIngresoMailSinUsuario()
        {
            Usuario usuario = new Usuario();

            var mail = "@mail.com";

            Assert.IsFalse(usuario.ValidarMail(mail));
        }

        [TestMethod]
        public void TestIngresoMailSinDominio()
        {
            Usuario usuario = new Usuario();

            var mail = "usuario@";

            Assert.IsFalse(usuario.ValidarMail(mail));
        }

        [TestMethod]
        public void TestIngresoMailValido()
        {
            Usuario usuario = new Usuario();

            var mail = "usuario@mail.com";

            Assert.IsTrue(usuario.ValidarMail(mail));
        }

        [TestMethod]
        public void TestIngresoContrasenaVacia()
        {
            Usuario usuario = new Usuario();

            string contrasena = "";

            Assert.IsFalse(usuario.ValidarContrasena(contrasena));
        }

        [TestMethod]
        public void TestIngresoContrasenaCorta()
        {
            Usuario usuario = new Usuario();

            string contrasena = "1234567";

            Assert.IsFalse(usuario.ValidarContrasena(contrasena));
        }

        [TestMethod]
        public void TestIngresoContrasenaValida()
        {
            Usuario usuario = new Usuario();

            string contrasena = "1234567abc!!";

            Assert.IsTrue(usuario.ValidarContrasena(contrasena));
        }
    }
}
