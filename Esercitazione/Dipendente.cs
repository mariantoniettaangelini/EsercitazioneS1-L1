using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Dipendenti
    {
        string nome;
        string cognome;
        string azienda;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public string Azienda
        {
            get { return azienda; }
            set { azienda = value; }
        }
        public void descrizioneDue()
        {
            Console.WriteLine("Mi chiamo" + " " + nome + " " + cognome + " " + "e lavoro alla" + " " + azienda);
        }
    }
}

