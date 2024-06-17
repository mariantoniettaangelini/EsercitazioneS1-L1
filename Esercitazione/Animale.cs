using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    internal class Animale
    {
        string nome;
        string specie;
        string dieta;
    

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }
    public string Dieta
        {
            get { return dieta; }
            set { dieta = value; }
        }
    public void descrizioneTre()
        {
            Console.WriteLine("Mi chiamo" + " " + nome + " " + "sono un" + " " + specie + " " + "e sono" + " " + dieta);
        }

}
}
