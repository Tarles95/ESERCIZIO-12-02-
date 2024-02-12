using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Utente
    {
        private List<double> prezziSelezionati = new List<double>();

        public void Menu()
        {
            int scelta;
            do
            {
                Console.WriteLine("\nBenvenuto, Cosa vuoi ordinare? \n ");
                Console.WriteLine("\n Scegli l'operazione da effettuare:\n");
                Console.WriteLine("1: Coca Cola 150 ml(€ 2.50)");
                Console.WriteLine("2: Insalata di pollo(€ 5.20)");
                Console.WriteLine("3: Pizza Margherita(€ 10.00)");
                Console.WriteLine("4: Pizza 4 Formaggi(€ 12.50)");
                Console.WriteLine("5: Pz patatine fritte(€ 3.50)");
                Console.WriteLine("6: Insalata di riso(€ 8.00)");
                Console.WriteLine("7: Frutta di stagione(€ 5.00)");
                Console.WriteLine("8: Pizza fritta(€ 5.00)");
                Console.WriteLine("9: Piadina vegetariana(€ 6.00)");
                Console.WriteLine("10: Panino Hamburger(€ 7.90)");
                Console.WriteLine("11: Fine ordine");

                if (int.TryParse(Console.ReadLine(), out scelta))
                {
                    if (scelta >= 1 && scelta <= 10)
                    {
                        double prezzoOggetto = OttieniPrezzo(scelta);
                        prezziSelezionati.Add(prezzoOggetto);
                        Console.WriteLine($"Hai aggiunto € {prezzoOggetto} all'ordine.");
                    }
                    else if (scelta == 11)
                    {
                        double sommaTotale = CalcolaSommaTotale();
                        Console.WriteLine($"Totale dell'ordine: € {sommaTotale}");
                        Console.ReadLine();
                    }
                    
                    else
                    {
                        Console.WriteLine("Scelta non valida. Riprova.");
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Inserisci un numero.");
                }

            } while (scelta != 11);
        }

        private double OttieniPrezzo(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    return 2.50;
                case 2:
                    return 5.20;
                case 3:
                    return 10.00;
                case 4:
                    return 12.50;
                case 5:
                    return 3.50;
                case 6:
                    return 8.00;
                case 7:
                    return 5.00;
                case 8:
                    return 5.00;
                case 9:
                    return 6.00;
                case 10:
                    return 7.90;
                default:
                    return 0.00;
            }
        }
        
        private double CalcolaSommaTotale()
        {
            
            double sommaTotale = 0.0;
            foreach (var prezzo in prezziSelezionati)
            {
                sommaTotale += prezzo;
            }
            
            return sommaTotale;
            


        }

    }
    
}
