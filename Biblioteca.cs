using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git_Biblioteca
{
    internal class Biblioteca
    {
        public string Nome {  get; set; }
        public string Indirizzo { get; set; }
        public double OrarioApertura { get; set; }
        public double OrarioChiusura { get; set; }
        public List<Libro> Libri {  get; set; }

        public Biblioteca(string nome, string indirizzo, double orarioApertura, double orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Libri = new List<Libro>();
        }
        public void AggiuntaLibro(Libro libro) {
            Libri.Add(libro);
        }

        public List<Libro> CercaTitolo(string titolo)
        {
            List<Libro>LibriTrovatiTitolo = new List<Libro>();
            foreach (Libro libro in Libri)
            {
                if (libro.Titolo.Contains(titolo))
                {
                    LibriTrovatiTitolo.Add(libro);
                }
            }
            if (LibriTrovatiTitolo.Count == 0)
            {
                Console.WriteLine("Non sono stati trovati libri con questo titolo");
            }
            return LibriTrovatiTitolo;
        }

    }
}
