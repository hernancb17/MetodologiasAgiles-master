using System.Text.RegularExpressions;

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
            return Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
        
        public bool ValidarContrasena(string contrasena)
        {
            return contrasena.Length >= 8;
        }
    }
}
