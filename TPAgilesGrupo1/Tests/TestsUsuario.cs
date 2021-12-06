using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TPAgilesGrupo1.Model;

namespace TestsUsuario
{
    [TestClass]
    public class TestIngresoUsuario
    {
        [TestMethod]
        public void TestIngresoMailVacio()
        {
            Invitado usuario = new Usuario();

            var mail = "";

            Assert.IsFalse(usuario.ValidarMail(mail));
        }

    }
}
