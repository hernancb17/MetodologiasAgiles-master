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

    }
}
