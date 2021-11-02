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
        private int IntentosRestantes = 6;
        public string PalabraCorrecta = "METODOLOGIAS AGILES";
        private string PalabraCorrectaModificada;

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
        
        public int Jugar(string intento)
        {
            PalabraCorrectaModificada = PalabraCorrecta.Replace(" ", "");
            int lenAnterior = PalabraCorrectaModificada.Length;

            PalabraCorrectaModificada = PalabraCorrectaModificada.Replace(intento, "");

            if (lenAnterior == PalabraCorrectaModificada.Length)
            {
                IntentosRestantes--;
            }

            return IntentosRestantes;
        }
    }
}
