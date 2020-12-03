using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportello
{
    class Dipendente
    {
        // definisco due proprietà automatiche per il cognome e il nome
        public string Cognome
        {
            get; private set;
        }

        public string Nome
        {
            get; private set;
        }


        decimal stipendio;

        public decimal Stipendio
        {
            get
            {
                return stipendio;
            }

            set
            {
                // value rappresenta il valore assegnato alla proprietà; è disponibile solo nel ramo set di una proprietà

                if (value >= 300)
                    stipendio = value;
                else
                    throw new Exception("Un dipendente deve avere uno stipendio minimo di 300 euro");
            }
        }


        public Dipendente(string cognome, string nome)
        {
            this.Cognome = cognome.Trim().ToUpper();
            this.Nome = nome.Trim().ToUpper();

            if (this.Cognome == "" || this.Nome == "")
                throw new Exception("Un dipendente deve avere nome e cognome definiti");
        }
    }
}
