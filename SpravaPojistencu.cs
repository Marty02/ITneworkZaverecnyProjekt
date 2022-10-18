using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkouskaProjekt
{
    /// <summary>
    /// Třída pro správu pojištěnců
    /// </summary>
    internal class SpravaPojistencu
    {
        private List<Pojistenec> seznamPojistencu = new List<Pojistenec>()
        {
            // Testovací data. Před nasazením do ostrého provozu odebrat!
            new Pojistenec("David", "Novák", "+420 328 858 468", 32),
            new Pojistenec("Marcel", "Lhotka", "+420 985 486 123", 45),
            new Pojistenec("Martin", "Kovanda", "+420 427 789 159", 32)
        };

        /// <summary>
        /// Metoda pro přidání pojištěnce
        /// </summary>
        /// <param name="List">Seznam pojištěnců</param>
        public void PridejPojistence()
        {
            string jmeno = "";
            while (String.IsNullOrWhiteSpace(jmeno))
            {
                Console.WriteLine("Zadejte jméno pojištěnce: ");
                jmeno = Console.ReadLine();
            }
            string prijmeni = "";
            while (String.IsNullOrWhiteSpace(prijmeni))
            {
                Console.WriteLine("Zadejte příjmení: ");
                prijmeni = Console.ReadLine();
            }
            string telefon = "";
            while (String.IsNullOrWhiteSpace(telefon))
            {
                Console.WriteLine("Zadejte telefonní číslo: ");
                telefon = Console.ReadLine();
            }
            int vek = 0;
            Console.WriteLine("Zadejte věk: ");
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Zadejte věk: ");

            seznamPojistencu.Add(new Pojistenec(jmeno, prijmeni, telefon, vek));
        }
        /// <summary>
        /// Metoda pro výpis všech pojištěnců v seznamu
        /// </summary>
        /// <param name="List">Seznam pojištěnců</param>
        public void VypisVsechPojistencu()
        {
            var pojistenci = seznamPojistencu.OrderBy(p => p.Prijmeni).ThenBy(p => p.Jmeno).ThenByDescending(p => p.Vek);
            VypisVystup(pojistenci);
        }
        /// <summary>
        /// Metoda pro vyhledání pojištěnce
        /// </summary>
        /// <param name="List">Seznam pojištěnců</param>
        public void VyhledatPojisteneho()
        {
            string jmeno = "";
            while (String.IsNullOrWhiteSpace(jmeno))
            {
                Console.WriteLine("Zadejte jméno pojištěnce: ");
                jmeno = Console.ReadLine();
            }
            string prijmeni = "";
            while (String.IsNullOrWhiteSpace(prijmeni))
            {
                Console.WriteLine("Zadejte příjmení: ");
                prijmeni = Console.ReadLine();
            }

            var pojistenci = seznamPojistencu.Where(p => p.Jmeno.ToLower() == jmeno.ToLower() && p.Prijmeni.ToLower() == prijmeni.ToLower()).OrderBy(p => p.Prijmeni).ThenBy(p => p.Jmeno).ThenByDescending(p => p.Vek);
            if (pojistenci.Count() > 0)
            {
                Console.WriteLine();
                VypisVystup(pojistenci);
            }
            else
            {
                Console.WriteLine("Nebyl nalezen žádný záznam.");
            }
        }

        private void VypisVystup(IEnumerable<Pojistenec> pojistenci)
        {
            foreach (Pojistenec p in pojistenci)
            {
                Console.WriteLine(p.ToString());
             }
        }
    }
}
