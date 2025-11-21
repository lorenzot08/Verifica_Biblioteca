namespace Verifica_Git_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nella mia biblioteca");
            // Libri creati per esempio
            Libro l1 = new Libro("Manzoni", "Promessi Sposi", 1340, "Zanichelli", 150);
            Libro l2 = new Libro("Dante", "Divina Commedia", 1500, "Zanichelli", 450);
            Biblioteca b1 = new Biblioteca("Biblioteca Centrale", "Cesena, piazza del Popolo", 8.30, 19.30);

            int scelta;
            do
            {
                Console.WriteLine("--- Menu Biblioteca ---");
                Console.WriteLine("1-> Aggiungi i due libri creati per esempio");
                Console.WriteLine("2-> Cerca un libro per titolo");
                Console.WriteLine("3-> Cerca un libro per autore");
                Console.WriteLine("4-> Mostra il numero di libri");
                Console.WriteLine("5-> Esci");
                Console.Write("Scelta: ");

                scelta = int.Parse(Console.ReadLine());
                //Uso uno swithc per creare un menù come una sorta di interfaccia che consente all'utente di interagire
                switch (scelta)
                {
                    case 1:
                        b1.AggiuntaLibro(l1);
                        b1.AggiuntaLibro(l2);
                        break;

                    case 2:
                        Console.Write("Inserisci il titolo da cercare: ");
                        string titolo = Console.ReadLine();
                        List<Libro> trovatiT = b1.CercaTitolo(titolo);
                        foreach (Libro lib in trovatiT)
                            Console.WriteLine(lib);
                        break;

                    case 3:
                        Console.Write("Inserisci l'autore da cercare: ");
                        string autore = Console.ReadLine();
                        List<Libro> trovatiA = b1.CercaAutore(autore);
                        foreach (Libro lib in trovatiA)
                            Console.WriteLine(lib);
                        break;

                    case 4:
                        Console.WriteLine($"Numero di libri presenti in biblioteca: {b1.NumeroLibri()}");
                        break;

                    case 5:
                        Console.WriteLine("Uscita in corso...");
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            } while (scelta!=5);// uso un do-while perchè così l'utente può effettuare diverse scelte
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(b1);
            Console.WriteLine($"Numero di ore per leggere il libro numero 1:{l1.ReadingTime()}");
            Console.WriteLine($"Numero di ore per leggere il libro numero 2:{l2.ReadingTime()}");
        }
    }  
}
