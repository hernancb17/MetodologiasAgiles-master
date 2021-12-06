using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TPAgilesGrupo1.Model
{
    public class Usuario : UsuarioBase
    {
        public string mail;
        public string contrasena;

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
