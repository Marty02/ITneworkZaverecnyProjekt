using System.Text;
using ZkouskaProjekt;

SpravaPojistencu sprava = new SpravaPojistencu();

bool konec = false;
while (!konec)
{
    Console.Clear();
    Console.WriteLine("------------------------------");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("------------------------------");
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");

    char volba = Console.ReadKey().KeyChar;
    Console.WriteLine("\n");

    switch (volba) {
        case '1':
            sprava.PridejPojistence();
            break;
        case '2':
            sprava.VypisVsechPojistencu();
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();
            break;
        case '3':
            sprava.VyhledatPojisteneho();
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
            Console.ReadKey();
            break;
        case '4':
            konec = true;
            Console.Clear();
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu...");
            Console.ReadKey();
            break;
    }
}
