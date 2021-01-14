using System;
using System.Collections.Generic;

/* TODO: Implementare la classe Valutazione, che rappresenta una singola valutazione di uno studente con nome della materia e voto (da 1 a 10).
 */

namespace Recupero
{
    class Valutazione
    {
        string materia;
        int voto;

        public string Materia
        {
            get => materia;

            private set
            {
                value = value.Trim().ToUpper();
                if (value != "")
                    materia = value;
                else
                    throw new Exception("La materia non può essere vuota");
            }
        }

        public int Voto
        {
            get => voto;

            set
            {
                if (value >= 1 && value <= 10)
                    voto = value;
                else
                    throw new Exception("Il voto deve essere compreso tra 1 e 10");
            }
        }

        public Valutazione(string m, int v)
        {
            Materia = m;
            Voto = v;
        }

        public override string ToString() => $"{Materia}: {Voto}";

        // Ricorda: se metodi, costruttori e get/set di proprietà hanno un'unica istruzione, posso usare la forma compatta con un corpo di espressione (v. ad esempio i getter delle proprietà Materia e Voto e il metodo ToString)
    }
}
