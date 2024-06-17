using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Veicolo
    {
        string veicol;
        string marca;
        int immatricolazione;
    
    
    public string Veicol
    {
        get { return veicol; }
        set { veicol = value; }
    }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Immatricolazione
        {
            get { return immatricolazione; }
            set { immatricolazione = value; }
        }

        public void descrizioneQuattro()
        {
            Console.WriteLine("Questo veicolo è una" + " " + veicol + " " + marca + " " + "ed è del" + " " + immatricolazione);
        }

    }
}
