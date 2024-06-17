using Atleta;

namespace Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleti mario = new Atleti();
            mario.Nome = "Mario";
            mario.Cognome = "Rossi";
            mario.Sport = "Calcetto";
            mario.descrizione();

            Dipendenti a = new Dipendenti();
            a.Nome = "Mario";
            a.Cognome = "Rossi";
            a.Azienda = "Pampers";
            a.descrizioneDue();

            Animale b = new Animale();
            b.Nome = "Pippo";
            b.Specie = "orso";
            b.Dieta = "carnivoro";
            b.descrizioneTre();

            Veicolo c = new Veicolo();
            c.Veicol = "automobile";
            c.Marca = "Ford";
            c.Immatricolazione = 2000;
            c.descrizioneQuattro();
            
        }
    }
}
