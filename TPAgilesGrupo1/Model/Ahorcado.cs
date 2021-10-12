using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAgilesGrupo1.Model
{
    public class Ahorcado
    {
        private const string PalabraCorrecta = "METODOLOGIAS AGILES";

        public bool ValidarIntento(string intento)
        {
            return intento.ToUpper().Equals(PalabraCorrecta);
        }
    }
}
