using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    internal class Atleti
    {
        string nome;
        string cognome;
        string sport;
    

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

    public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }
    public void descrizione()
        {
            Console.WriteLine("Mi chiamo" + " " + nome + " " + cognome + " " + "e gioco a" + " " + sport);
        }
    }

}
