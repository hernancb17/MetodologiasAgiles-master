using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAgilesGrupo1.Model
{
    class User
    {
    }
}


namespace TPAgilesGrupo1.Model
{
    public class Usuario : Invitado
    {
        public string mail;
        public string contrasena;

        public Usuario() : base()
        {
        }
        public Usuario(string nombre) : base(nombre)
        {
        }

        public bool ValidarMail(string mail)
        {
            return false;
        }

        public bool ValidarContrasena(string contrasena)
        {
            return false;
        }
    }
}
