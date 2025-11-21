using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git_Biblioteca
{
    internal class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoPubblicazione;
        private string _editore;
        private int _numPagine;
        public string Autore { get { return _autore; } set { _autore = value; } }
        public string Titolo { get { return _titolo; } set { _titolo = value; } }
        public int AnnoPubblicazione { get { return _annoPubblicazione; } set { _annoPubblicazione = value; } }
        public string Editore { get { return _editore; } set { _editore = value; } }
        public int NumPagine { get { return _numPagine; } set { _numPagine = value; } }
        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumPagine = numPagine;
        }

        public override string ToString()
        {
            return $"L'autore del libro è: {Autore}, il titolo è: {Titolo}, l'anno di pubblicazione è: {AnnoPubblicazione}, l'editore è: {Editore}, le pagine totali sono: {NumPagine}";
        }
        public string ReadingTime()
        {
            string ore="0h";
            if (NumPagine < 100)
                ore = "1h";
            else if (NumPagine <= 200)
                ore = "2h";
            else
                ore=">2h";
            return ore ;

        }
    }
}


