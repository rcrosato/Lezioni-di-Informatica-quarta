using System;
using System.Collections.Generic;

/* TODO: Implementare la classe  Studente, caratterizzata dagli attributi: nome (contiene il cognome e nome dello studente) e lista di valutazioni che rappresenta le valutazioni di fine anno dello studente nelle singoli materie (una materia non può essere ripetuta).

  La classe dovrà esporre:

  - un costruttore che accetti il nome dello studente;
  - un costruttore che accetti il nome e una lista di valutazioni (la lista passata può presentare la stessa materia ripetuta più volte, in tal caso considerare per quella materia la media dei voti, arrotondata all'intero)
  - un metodo che accetti come argomento una lista di valutazioni (vedi esempio costruttore);
  - una proprietà che restituisca il nome dello studente
  - un indicizzatore che restituisca il voto dello studente nella materia il cui indice numerico è passato come parametro
  - un indicizzatore che restituisca la valutazione dello studente nella materia il cui nome è passato come parametro
  - un metodo che calcoli la media dei voti
  - un metodo che ritorni il numero di insufficienze
  - un metodo che ritorni il numero di insufficienze gravi (voto <= 4);
  - un metodo ToString() che fornisca una rappresentazione testuale di un’istanza della classe. Ad esempio: "Tizio – ITALIANO: 6; STORIA: 7; INGLESE: 5; MATEMATICA: 7; ..."
*/

namespace Recupero
{
    class Studente
    {
        string nome;
        List<Valutazione> valutazioni;


        public Studente(string nome)
        {
            nome = nome.Trim().ToUpper();
            if (nome != "")
                this.nome = nome;
            else
                throw new Exception("Uno studente deve avere un nome");
            valutazioni = new List<Valutazione>();
        }

        public Studente(string nomeS, List<Valutazione> voti) : this(nomeS) => AggiornaVoti(voti);

        public void AggiornaVoti(List<Valutazione> voti)
        {
            List<Valutazione> cloneVoti = new List<Valutazione>(voti);

            // toglie i duplicati dalla lista di origine e li sostituisce con la media
            for (int i = 0; i < cloneVoti.Count; i++)
            {
                double sommaVoti = cloneVoti[i].Voto;
                int contaVoti = 1;
                int j = i + 1;
                while (j < cloneVoti.Count)
                {
                    if (cloneVoti[j].Materia == cloneVoti[i].Materia)
                    {
                        sommaVoti += cloneVoti[j].Voto;
                        contaVoti++;
                        cloneVoti.RemoveAt(j);
                    }
                    else
                        j++;
                }
                cloneVoti[i].Voto = (int)Math.Round(sommaVoti / contaVoti);
            }

            // aggiorna la lista valutazioni dello studente (Nota: visto che può essere aggiornata solo con il metodo AggiornaVoti, non potranno esserci materie duplicate)
            foreach (Valutazione v in cloneVoti)
            {
                Valutazione vs = this[v.Materia];
                if (vs == null)
                    valutazioni.Add(new Valutazione(v.Materia, v.Voto));
                else
                    vs.Voto = v.Voto;
            }
        }
        
        // Ritorna la valutazione in una determinata materia e null se la materia non esite
        public Valutazione this[string materia]
        {
            get
            {
                Valutazione val = null;
                for (int i = 0; val == null && i < valutazioni.Count; i++)
                    if (valutazioni[i].Materia == materia)
                        val = valutazioni[i];
                return val;
            }
        }


        // Ricorda: per le proprietà in sola lettura (cioè con il solo ramo get) posso usare la forma compatta come di seguito
        public string Nome => nome;


        public int this[int indice] => valutazioni[indice].Voto;

        public double MediaVoti()
        {
            // calcolare la media delle valutazioni che sono già associate allo studente
            double somma = 0;
            foreach (Valutazione v in valutazioni)
                somma += v.Voto;
            return somma / valutazioni.Count;
        }

        public int Insufficienze()
        {
            int conta = 0;
            foreach (Valutazione v in valutazioni)
                if (v.Voto < 6)
                    conta++;
            return conta;
        }

        public int InsufficienzeGravi()
        {
            int conta = 0;
            foreach (Valutazione v in valutazioni)
                if (v.Voto <= 4)
                    conta++;
            return conta;
        }

        public override string ToString()
        {
            string s = $"{Nome} - ";
            foreach (Valutazione v in valutazioni)
                s += $"{v.ToString()}; ";
            return s;
        }
    }
}
