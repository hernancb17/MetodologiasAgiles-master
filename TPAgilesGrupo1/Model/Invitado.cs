using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TPAgilesGrupo1.Model
{
    public class Invitado
    {
        public string nombre;

        public Invitado()
        {
            this.nombre = "guest451656";
        }
        public Invitado(string nombre)
        {
            if (ValidarIngreso(nombre))
            {
                this.nombre = nombre;
            }
        }

        public bool ValidarIngreso(string nombreIngresado)
        {
            if (nombreIngresado.Length > 2 && nombreIngresado.Length < 20)
            {
                Regex expresionRegular = new Regex(@"[a-zA-Z0-9]");

                var devolucion = expresionRegular.Matches(nombreIngresado);

                return devolucion.Count == nombreIngresado.Length ? true : false;
            }

            return false;
        }
    }
}