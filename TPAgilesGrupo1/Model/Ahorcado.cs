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
        public string PalabraCorrecta;
        private string PalabraCorrectaModificada;
        public int Puntaje = 0;
        private int PuntosPorIntento = 10;

        public Ahorcado()
        {
            PalabraCorrecta = "METODOLOGIAS AGILES";
        }
        public Ahorcado(string palabra)
        {
            PalabraCorrecta = palabra;
        }

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
                if (Puntaje - PuntosPorIntento < 0)
                {
                    Puntaje = 0;
                }
                else
                {
                    Puntaje -= PuntosPorIntento;
                }
            }
            else
            {
                Puntaje += PuntosPorIntento;
            }

            return IntentosRestantes;
        }
    }
}
