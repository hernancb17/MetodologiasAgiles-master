using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TPAgilesGrupo1.Model
{
    public class Ahorcado
    {
        public string PalabraCorrecta = "METODOLOGIAS AGILES";

        public bool ValidarIntento(string intento)
        {
            return intento.ToUpper().Equals(PalabraCorrecta);
        }

        public bool ValidarIngresoLetra(string intentoLetra)
        {
            Regex expresionRegular = new Regex(@"[a-zA-Z]");

            var letraValidada = expresionRegular.Matches(intentoLetra);

            return letraValidada.Count == 1 ? true : false;
        }
        
        public void ValidarJuego(string intento, int cont)
        {
            PalabraCorrecta = PalabraCorrecta.Replace(intento, "");
        }
    }
}
