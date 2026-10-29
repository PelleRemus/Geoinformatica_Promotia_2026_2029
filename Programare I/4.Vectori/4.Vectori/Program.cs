// Spuneam ca un string se scrie intre un set de ghilimele duble: "string". Dar daca dorim, de exemplu, sa avem in interior
// la stringul respectiv caracterul ghilimele? "Iar persoana mi-a spus "Ne vedem data viitoare"".
// Pentru a putea folosi astfel de caractere, trebuie sa folosim caracterul \ (backslash).
// Astfel codul va sti ca este un caracter special: "Iar persoana mi-a spus \"Ne vedem data viitoare\"".
// Alte caractere speciale sunt:
// - \' (pentru char): '\''
// - \n (new line): trecem pe randul urmator
// - \r (carriage return): echivalent cu "Shift + Enter" in Word
// - \t (tab): un caracter de tip spatiu, de lungime flexibila, ex pentru afisarea unui tabel de numere intre 1 si 999:
//      1    123 63  2   10
//      123  66  87  32  3
// - \v (tab vertical)
// - \\ (backslash in sine): util pentru "path"-urile din PC: "C:\\users\\..."

// Daca stim ca urmeaza sa folosim multe backslash-uri in string, cum ar fi pentru path-uri,
// si nu avem alte caractere speciale, putem sa ii spunem codului sa nu foloseasca astfel de caractere,
// si atunci nu mai trebuie sa punem de foarte multe ori "\\" in interior la string, functioneaa si cu un singur "\".
// Ii spunem codului lucrul asta printr-un "@" (shift + 2) inainte de ghilimelele de deschidere a stringului

//string propozitie = "Iar persoana mi-a spus "Ne vedem data viitoare""; // Nu functioneaza
string propozitie = "Iar persoana mi-a spus \"Ne vedem data viitoare\"";

//char ghilimea = '''; // Nu functioneaza
char ghilimea = '\'';

string maiMulteRanduri = "rand 1\nrand 2";
Console.WriteLine(maiMulteRanduri);

string carriageReturn = "rand 1\rrand 2";
Console.WriteLine(carriageReturn); // Se comporta foarte ciudat

string tab1 = "1\t123\t63\t2\t10";
string tab2 = "123\t66\t87\t32\t3";
Console.WriteLine($"{tab1}\n{tab2}");

Console.WriteLine($"{tab1}\v\v{tab2}");

//string path1 = "C:\Users\remus\Documents\GitHub\Geoinformatica_Promotia_2026_2029\Programare I"; // Nu functioneaza
string path1 = "C:\\Users\\remus\\Documents\\GitHub\\Geoinformatica_Promotia_2026_2029\\Programare I";

string path2 = @"C:\Users\remus\Documents\GitHub\Geoinformatica_Promotia_2026_2029\Programare I";
string relativePath = @"..\..\..\..\..\..\Programare I"; // Echivalent cu path-urile absolute de mai sus

// O variabila constanta este o variabila care nu poate primi o alta valoare decat prima atribuita.
// Utila pentru variabile fixe, cum ar fi numarul pi din matematica
double pi = 3.1415;
pi = 3; // Nu ar trebui sa avem voie sa facem asta

const double Pi = 3.1415;
//Pi = 3; // Nu functioneaza


// --------------------------------------------------- VECTORI ---------------------------------------------------
// Exemplu de exercitiu: Se citesc 5 numere intregi din consola. Afisati suma lor
int a, b, c, d, e;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
e = int.Parse(Console.ReadLine());

Console.WriteLine(a + b + c + d + e);

// Acum, daca dorim suma a 100 de numere citite din consola? Ar fi cam inconvenient sa avem cate un program pregatit
// pentru orice numar de numere care trebuiesc insumate. Pentru astfel de tipuri / exemple de exercitii, vom introduce
// un nou tip de date: vector. Un "vector" (array) este o variabila care retine in memorie o colectie de date de acelasi tip.
// Adica pentru 100 de numere, vom avea o singura variabila, si fiecare numar se va afla pe o pozitie din acest vector
// Ex: [1, 2, 3, 4, 5]
// Valoarea numarului 4 se afla pe pozitia 3 a vectorului (numerotarea se face de la 0, la fel ca si la string)
// Pentru declarare, avem nevoie sa scriem tipul de date si sa punem o parantea dreapta deschisa, si una inchisa,
// semnificand vector. Pentru initializare, putem sa dam lungimea acestui vector, sau putem sa dam tot vectorul,
// intre paranteze drepte, cu valorile separate prin virgula, ca si mai sus
int[] vector = new int[5];
vector[0] = int.Parse(Console.ReadLine());
vector[1] = int.Parse(Console.ReadLine());
vector[2] = int.Parse(Console.ReadLine());
vector[3] = int.Parse(Console.ReadLine());
vector[4] = int.Parse(Console.ReadLine());

Console.WriteLine(vector[0] + vector[1] + vector[2] + vector[3] + vector[4]);

// Modul in care am scris codul deocamdata nu rezolva deloc problema pe care am avut-o. Asta este pentru ca trebuie sa mai
// introducem si un nou "block" de cod similar cu if-ul, care ne ajuta sa repetam lucruri similare de mai multe ori.
// Acest block se numeste "for", iar similaritatea intre cele 5 randuri care citesc de la consola este evidenta, singura
// diferenta fiind pozitia / indicele. cu un for, putem da valori crescatoare unei variabile "i" (indice), pe care sa
// o folosim intre parantezele drepte.
vector = new int[5];

for (int i = 0; i < 5; i = i + 1)
{
    vector[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(vector[0] + vector[1] + vector[2] + vector[3] + vector[4]);

// Acum pentru suma a 100 de numere, ne-ar fi mai simplu sa le citim. Dar inca trebuie sa le scriem manual pentru suma lor.
// Putem folosi inca o variabila, care incepe de la 0, pentru suma, si care creste imediat dupa ce citim un numar nou
vector = new int[100];
int suma = 0;

for (int i = 0; i < 100; i = i + 1)
{
    vector[i] = int.Parse(Console.ReadLine());
    suma = suma + vector[i];
}

Console.WriteLine(suma);

// Si acum, pentru ultima versiune a codului: Sa se calculee suma unui numar necunoscut de numere, citite de la tastatura.
// Numarul de numere (cate se vor afla in vector) este primul numar citit din Consola.
int n = int.Parse(Console.ReadLine());
vector = new int[n];

for (int i = 0; i < n; i++) // i++ este prescurtare pentru "incrementare", echivalent cu "i = i + 1"
{
    vector[i] = int.Parse(Console.ReadLine());
    suma = suma + vector[i];
}

Console.WriteLine(suma);

// Pentru initializarea unei colectii cunoscute, putem scrie: int[] vector = [1, 2, 3, 4, 5];

// Exista un operator pentru calcularea restului impartirii a doua numere.
// Impartirea cu rest: a / b = c (rest d)
// Pentru valoarea lui d, putem scrie in cod: d = a % b (simbolul "la suta" / "procent")
// Foarte util pentru verificarea paritatii unui numar: in cazul unui numar par, stim ca se imparte exact la 2,
// deci restul impartirii cu 2 trebuie sa fie 0
int numar = 15;
if (numar % 2 == 0)
{
    Console.WriteLine("Numarul este par");
}
else
{
    Console.WriteLine("Numarul este impar");
}

// Un for are urmatoarele componete: for (<initial>; <conditie>; <final>)
// <initial> se executa o singura data, de obicei pentru declararea si initializarea lui i
// <conditie> se executa inaintea fiecarui pas. Atunci cand conditia e falsa, repetarea inceteaza, si iesim din for
// <final> se executa de fiecare data dupa ce se eecuta instructiunile dintre acoladele for-ului.
// Exemplu de exercitii pentru acasa:
// - produsul numerelor unui vector cunoscut;
// - afisarea tuturor valorilor unui vector (de preferat, intr-o singura linie)
// - afisarea in ordine descrescatoare a valorilor vectorului
// - suma valorilor mai mari decat 10 dintr-un vector
// - produsul valorilor de pe pozitii pare din vector
// - suma valorilor impare din vector
