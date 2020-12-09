using System;

namespace LezioniOOP
{
    public enum TipoAuto
    {
        DueVolumi, Berlina, StationWagon, FuoriStrada, Coupè, Cabriolet
    }

    /*
     * Caratteristiche degli attributi e metodi statici:
     * 
     * 1. sono membri che non sono legati al singolo oggetto ma sono membri condivisi tra tutti gli oggetti
     * 2. per riferirmi ad un membro statico devo usare il nome della classe (non l'identificatore dell'oggetto)
     * 3. dall'interno di un metodo statico posso riferirmi esclusicamente ad altri membri statici (attributi o metodi), non a membri di istanza
     * 
     * Nota bene che da un metodo non statico posso riferirmi a membri statici.
     */

    /// <summary>
    /// Classe per rappresentare automobili
    /// </summary>
    public class Auto
    {
        private string marca, modello;
        private int potenza;
        private TipoAuto tipo;

        private static int autoCreate = 0;

        // una proprietà definisce due metodi (get accessor e set accessor) per restituire un valore o impostare un valore

        // esempio di proprietà in sola lettura (c'è solo il ramo get)
        public string Marca
        {
            get
            {
                return marca;
            }
        }

        // esempio di proprietà in lettura e scrittura ma la scrittura è possibile solo dalla classe (è private)
        public string Modello
        {
            get
            {
                return modello;
            }

            private set
            {
                modello = value.ToUpper().Trim();
            }
        }

        // esempio di proprietà in lettura e scrittura
        public int Potenza
        {
            get
            {
                return potenza;
            }

            // nella parte set specifichiamo come deve essere usato il valore assegnato alla proprietà, valore che trovo all'interno della variabile locale value
            set
            {
                potenza = (value >= 1 ? value : 1);
            }
        }


        // proprietà automatiche: non sono legate a campi della classe
        public Decimal Prezzo
        {
            get; private set;
        }


        public static string AutoCreate()
        {
            string s = $"Ci sono {autoCreate} automobili in memoria";
            return s;
        }

        // esempio di costruttore (a due parametri)
        public Auto(string marca, string modello)
        {
            this.marca = marca.ToUpper().Trim();
            Modello = modello;
            autoCreate++;
        }

        public Auto(string ma, string mo, int potenza): this(ma, mo) =>
            this.Potenza = potenza; 

        public Auto(string marca, string modello, int potenza, TipoAuto tipo): this(marca, modello, potenza) => this.tipo = tipo;
        

        // distruttore 
        ~Auto()
        {
            // codice di pulizia per deallocare o chiudere oggetti esterni al programma
            autoCreate--;
        }

        public string Informazioni() => $"Sono un auto {this.marca} {this.modello}";        

        public void Elabora() => this.potenza = (int)(this.potenza * 1.1);



        // manteniamo al massimo gli ultimi cinque proprietari dell'auto
        private const int MAX_PROPRIETARI = 5;
        private string[] proprietari = new string[MAX_PROPRIETARI];

        private int numeroPropietari = 0;


        // l'indicizzatore seguente restituisce il 1^, 2^, ... proprietario dell'auto, quindi i può valere 1, 2, ..., numeroProprietari
        public string this[int i]
        {
            get
            {
                if (i >= 1 && i <= numeroPropietari)
                    return proprietari[i - 1];
                else
                    throw new ArgumentException("i", "Argomento fuori dai limiti");
            }
        }
    }
}
