using System.Threading.Channels;

Console.WriteLine("Hello, World!");
Console.WriteLine("Ana are mere");

Console.Write("Ana are mere");
Console.WriteLine(" si pere");

Console.WriteLine(43 / 4);
Console.WriteLine(43.0 / 4);

string animal = "soarece";
Console.WriteLine(animal);

Console.WriteLine("Animalul meu de companie este " + animal);

animal = "caine";
Console.WriteLine("Animalul meu de companie este " + animal);

int inmultire = (30 - 5) * 2;
Console.WriteLine(inmultire);

Console.WriteLine(inmultire - 10);

double real = 40.0 / 3;
Console.WriteLine(real);

string legume = Console.ReadLine();
Console.WriteLine(legume);

// -----------------------------------------------------------------------------------------
// Conversiile de tip de date se poate realia automat (implicit) sau explicit.
// In momentul in care atribuim unui numar real (double) o valoare intreaga,
// calculatorul deja face conversia de la valoarea intreaga (12) la valoarea reala (12.0).
double numarReal = 12;

// Dar nu toate conversiile se intampla atat de usor / natural. Motivul pentru care
// functioneaza pentru numere reale care primesc valori intregi, este pentru ca
// nu se pierd date. 12 si 12.0 sunt echivalente, deci conversia se poate face simplu / automat.
// Dar daca dorim sa facem conversia inversa, adica sa salvam un numar cu virgula
// intr-o variabila intreaga, vom primi o eroare
//int numarIntreg = 12.3; // Eroare: Cannot implicitly convert type 'double' to 'int'

// Pentru exemplul de mai sus, s-ar pierde datele de dupa virgula, de aceea conversia
// nu se face implicit. In aceasta situatie, daca vrem sa fortam aceasta conversie,
// trebuie facuta explicit. Pentru numere, se poate face "casting" in modul urmator:
// (<tip de date>)<valoare>. Exemplu: (int)12.3
int numarIntreg = (int)12.3;
Console.WriteLine(numarIntreg);

// Un alt motiv pentru care nu s-ar putea face conversie implicita este pentru ca nu exista
// un mod sigur de a face conversia, cum ar fi intre string si int. "53" se poate converti
// usor, dar "asd" nici macar nu functioneaza. De aceea este nevoie de o conversie explicita,
// de obicei numai dupa ce ne asiguram ca este in siguranta (nu am da valori gresite
// si nu ar da eroare). Conversia de la string la int nu se poate face cu casting,
// pentru ca string nu este numar, nu se face o simpla proiectie, ci este mai complicat
// codul pe care il executa acea functie de convertire. Metoda pentru conversie de string
// se numeste "Parsing", si exista pe orice tip de date implicit (primitiv) inafara de string.
// Ex: int.Parse("53"); double.Parse("31.2");
double numarConvertit = double.Parse("17.8");
Console.WriteLine(numarConvertit);

// Acum ca stim aceste metode de conversiune, putem citi de la Consola (tastatura) numere:
int nr = int.Parse(Console.ReadLine());
Console.WriteLine("Numarul ales este: " + nr);

// Sirurile de caractere au mai multe functii / operatii pe care le putem face cu ele,
// inafara de concatenare. De exemplu, putem afla lungimea unui text folosind proprietatea
// Length a acelei variabile
Console.WriteLine("Cuvantul '" + animal + "' are lungimea: " + animal.Length);

// In loc de concatenare, se poate folosi interpolarea de stringuri. Astfel putem folosi
// si valorile unor variabile in interiorul ghilimelelor, pentru usurinta de scriere.
// In plus, interpolarea este mai rapida (eficienta) decat concatenarea
Console.WriteLine($"Cuvantul '{animal}' are lungimea: {animal.Length}");

// Pentru a-i spune codului ca vom folosi interpolare, trebuie sa punem simbolul '$'
// in fata ghilimelelor. In interiorul ghilimelelor, trebuie sa punem intre acolade
// valoarea / variabila ce vrem sa se afiseze (ex: {animal}), iar stringul va sti
// sa nu afiseze exact ce am scris, ci sa interpretee codul, si sa afiseze valoare varibilei

// Un alt mod de a afisa acelasi lucru, ar fi sa folosim lista de valori in interiorul
// parametrilor functiei WriteLine. Pana acum, am dat un singur parametru, stringul ce urmeaza
// sa fie afisat, dar daca i-am da alti parametri, functia va cauta locuri din interiorul
// stringului in care avem numere intre acolade. Iar reultatul va inlocui acele numere
// cu valorile din lista de parametri (numarul ne spune ordinea din lista)
Console.WriteLine("Cuvantul '{0}' are lungimea: {1}", animal, animal.Length);
Console.WriteLine("Cuvantul '{1}' are lungimea: {0}", animal.Length, animal);

// Observam ca ordinea parametrilor incepe de la 0. De obicei, asta este cazul in informatica,
// si exact la fel numerotam si literele dintr-un string. Daca vrem sa accesam / afisam
// o anumita litera dintr-un text, putem folosi paranteze drepte [], intre care scriem pozitia
// literei, iar aceste paranteze se pun imediat dupa numele variabilei
string text = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine(text[0]); // a
Console.WriteLine(text[5]); // f
Console.WriteLine(text[25]); // z

// Stringul este un "sir de caractere", pentru ca defapt exista si tipul de date caracter,
// tipul 'char', si defapt cand folosim 'text[5]', afisam un astfel de char.
// Acestea se pot si ele declara, si cand vrem sa le folosim direct ca valoare ca pe un text,
// punem ghilimele singure
char litera = 'b';
Console.WriteLine(litera);

// Am vorbit despre operatiile aritmetice, dar putem avea si operatii logice in cod,
// cum ar fi verificare daca un numar este mai mare decat altul, sau daca este egal etc.
// Rezultatul acestor operatii logice va fi "true" sau "false", iar aceste valori
// reprezinta o "valoare booleana", ceea ce s-ar putea salva intr-o variabila "bool".
bool maiMare = 47 > 123;
Console.WriteLine($"47 > 123? Raspuns: {maiMare}");

// Pana acum, fiecare linie de cod a fost executata. Dar uneori vrem sa luam decizii, si sa
// executam ceva doar daca o anumita evaluare este "true", si se poate sa executam altceva
// in cazul in care evaluarea da rezultatul "false". Pentru acest lucru, folosim block-ul
// de executie logic "if", intre paranteze punem valoarea booleana, dupa care punem acolade
// pentru a sti ce linii de cod se executa cand rezultatul este True.
nr = int.Parse(Console.ReadLine());
if (nr > 123)
{
    Console.WriteLine($"Numarul {nr} este mai mare decat 123");
}

// Block-ul logic "else" nu poate exista singur. Se pune numai la sfarsitul unui if. Adica
// dupa ce se inchide acolada if-ului, doar atunci se poate scrie else. Este optional.
// Pentru else, nu este nevoie sa punem paranteze rotunde, pentru ca deja stim ca vom intra
// in codul acestuia doar daca conditia if-ului este falsa. Else de obicei are si el acolade.
string nume = Console.ReadLine();
if (nume.Length > 10)
{
    Console.WriteLine($"Numele introdus este lung! Are {nume.Length} litere");
}
else
{
    Console.WriteLine($"Numele introdus este scurt! Are doar {nume.Length} litere");
}