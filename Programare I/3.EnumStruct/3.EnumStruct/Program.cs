// Deocamdata, nu aveti nevoie sa va concentrati pe ce inseamna "namespace", "class", "internal", "static" etc
// Doar sa stiti ca, in loc sa scrieti codul direct, acesta trebuie "inglobat" in cele 3 seturi de acolade
// (adica dupa codul pe care l-ati scris, ar trebui sa aveti 3 linii cu acolade inchise, deocamdata)
namespace _3.EnumStruct
{
    // Nu scrieti codul aici..
    internal class Program
    {
        // "Enum" este un tip de date care descrie o enumeratie de elemente.
        // Numele enumeratiei se scrie imediat dupa cuvantul cheie "enum",
        // Dupa care deschidem acolade si enumeram elementele acesteia separate prin virgula.
        // Unul din scopurile pentru care se folosesc enumeratii este pentru ca fiecare dintre elemente
        // are asociat un numar (acesta se poate si schimba), si este mai usor de citit codul.
        enum ZileAleSaptamanii
        {
            Necunoscut = -1,
            Luni = 1,
            Marti,
            Miercuri,
            Joi,
            Vineri,
            Sambata,
            Duminica
        }

        // "Struct" este alt tip de date pe care il definim noi, precum enumeratia.
        // Acest tip de date poate sa contina proprietati care la randul lor au tipurile lor de date.
        // Scriem cuvantul cheie "struct", apoi numele tipului de date (al structurii), dupa care intre acolade
        // , definim proprietatile acesteia, prin linii sub forma "<tip> <nume_proprietate>;"
        struct Persoana
        {
            // Nu conteaza ce inseamna "public" deocamdata, trebuie sa stiti doar ca trebuie adaugat
            // in structura pentru a putea fi folosit la executarea programului
            public string nume;
            public int varsta;
        }

        struct Animal
        {
            // Daca tipul de date al proprietatilor este acelasi, se pot declara pe un singur rand (nu e recomandat)
            public string specie; //, culoare;
            public string culoare;
        }

        enum Anotimpuri
        {
            Iarna,
            Primavara,
            Vara,
            Toamna
        }

        static void Main(string[] args)
        {
            // --------------------------------------------------
            // | Aici se scrie codul ce urmeaza sa fie executat |
            // --------------------------------------------------

            // Cum folosim enumeratiile: numele enumeratiei poate fi folosit ca orice alt tip de date
            // pentru declararea unei variabile, adica in loc de "int nr = 10", putem scrie:
            ZileAleSaptamanii zi = ZileAleSaptamanii.Joi;

            // Aceasta variabila poate fi afisata in mod direct:
            Console.WriteLine(zi); // afiseaza "Joi"

            // Sau poate fi transformata in valoarea intreaga echivalenta cu conversie explicita
            Console.WriteLine($"{zi} este a {(int)zi}-a zi a saptamanii.");
            // Afiseaza "Joi este a 4-a zi a saptamanii"

            // Putem si sa afisam o valoare in mod direct, fara variabila
            Console.WriteLine(ZileAleSaptamanii.Necunoscut);
            Console.WriteLine((int)ZileAleSaptamanii.Necunoscut);


            // Pentru structuri, similar, folosim numele structurii pe post de tip de date.
            // Valoarea pe care o primeste un tip de date structura este de forma "new <struct>();",
            // ca si cum am zice "creeaza o noua Persoana" (pentru ca este o actiune, punem parantezele rotunde)
            Persoana student = new Persoana();

            // O varriabila de tipul unui struct nu poate fi usor afisat in mod direct:
            Console.WriteLine(student); // afiseaza doar ceva ce nu intelegem

            // Pentru a putea afisa ceva, trebuie intai sa dam valori proprietatilor din interior.
            // Pentru a accesa proprietatile, ca si pana acum, adaugam un punct (.) dupa variabila
            student.nume = "Ana";
            student.varsta = 20;

            // Acum le afisam pe rand, tot accesandu-le folosind punctul
            Console.WriteLine($"{student.nume} are {student.varsta} de ani.");

            // Daca schimbam una din valori, la afisare, se va modifica
            student.varsta = 21;
            Console.WriteLine($"{student.nume} are {student.varsta} de ani.");

            Animal caine = new Animal();
            caine.specie = "Labrador";
            caine.culoare = "galben";
            Console.WriteLine($"{caine.specie} are culoarea {caine.culoare}.");

            Console.WriteLine(Anotimpuri.Vara);
        }
    }
    // ..nici aici
}
// ..sau aici