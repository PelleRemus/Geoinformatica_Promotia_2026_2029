// Operatorii aritmetici sunt: +, -, * (inmultire), / (impartire), % (restul impartirii),
// ++ (incrementare, adica se aduna 1 la valoare: += 1), -- (decrementare, se scade 1: -= 1)
int numar = 15;
numar++; // Echivalent cu numar += 1, sau numar = numar + 1
Console.WriteLine(numar);
numar--; // numar -= 1, sau numar = numar - 1
Console.WriteLine(numar);

// Operatorii relationali sunt folositi de obicei pentru verificarea unor valori.
// "==" este operatorul de verificare daca valorile din stanga si din dreapta sa sunt egale intre ele.
// Nu se foloseste doar "=", pentru ca acest operator inseamna atribuire, adica dam valoare unei variabile
// Ex., cand am spus "numar = 15", nu am verificat daca numarul este egal cu 15, ci i-am dat valoarea 15 (atribuire)
Console.WriteLine(numar == 15);
Console.WriteLine(numar == 25);

// "!=" inseamna "diferit", deci verificam daca elementul din stanga este diferit de cel din dreapta
Console.WriteLine(numar != 15);
Console.WriteLine(numar != 25);

// Mai sunt operatorii >, <, >=, <= (mai mare sau egal, si mai mic sau egal)
Console.WriteLine(numar >= 15);
Console.WriteLine(numar <= 25);

// Pana acum, intr-un if, am folosit o singura conditie pentru a decide daca afisam ceva sau nu. Dar putem folosi
// operatorii logici pentru a combina rezultatele mai multor conditii, si astfel formam o conditie mai complexa.
// Pentru a verifica indeplinirea a doua conditii simultan, putem folosi operatorul "&&" (AND), caz in care rezultatul
// este True doar daca ambele conditii sunt True.
// Putem folosi si operatorul "||" (OR), pentru care rezultatul este True daca cel putin una din conditii este True.
// Putem nega orice conditie folosind in stanga opratorul "!" (NOT) (putem pune conditia intre paranteze)
int clasa = 7;
if (clasa >= 5 && clasa <= 8)
{
    Console.WriteLine("Gimnaziu");
}

if (!(clasa >= 5 && clasa <= 8))
{
    Console.WriteLine("Diferit de gimnaziu");
}

// Echivalent, negarea va inversa atat operatorii relationali, cat si pe cei logici, din interiorul parantezei
clasa = 9;
if (clasa < 5 || clasa > 8)
{
    Console.WriteLine("Diferit de gimnaziu");
}

// Operatorii pe biti lucreaa direct cu bitii unei valori / variabile. "Bitii" sunt valori doar de 0 si 1,
// Iar memoria calculatorului este formata integral din astfel de valori, interpretate pentru a afisa programe,
// rezultate de calcule etc. Fiind valori doar de 0 si 1, orice numar de eemplu, in memoria calculatorului, va fi salvat
// cu valoarea sa echivalenta in Baza 2. Numerele in mod normal sunt folosite in Baza 10.

// Operatorii de atribuire sunt folositi pentru a da valoare variabilei din stanga acestuia. Inafara de "=", sunt practic
// prescurtari pentru cei doi operatori imbinati. "x += y" este prescurtare pentru "x = x + y"
// Putem imbina toti operatorii aritmetici de baza, si cei pe biti, cu operatorul "=".

// Factorialul unui numar se notaza in matematica: "n!", si reprezinta produsul primelor n numere naturale nenule
// (diferite de 0). Adica, n! = 1 * 2 * 3 * ... * n. Hai sa calculam n factorial:
int n = int.Parse(Console.ReadLine());
long factorial = 1;

for (int i = 2; i <= n; i++)
{
    factorial *= i;
}
Console.WriteLine($"Factorialul numarului {n} este: n! = {factorial}");

// Sirul lui Fibonacci este tot o secventa care creste foarte repede, precum factorialul. Numarul "n" va reprezenta
// indicele numarului din sir pe care il cautam. Pentru generarea / calcularea valorilor din sirul lui Fibonacci,
// incepem cu primele doua valori din sir, de pe pozitiile 1 si 2: 1, 1, ...
// Formula pentru restul numerelor din sir este: X(n) = X(n-1) + X(n-2).
// Deci, primele valori din sir sunt: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
long[] x = new long[n]; // Vector de dimensiunea n, unde vom salva sirul lui fibonacci
x[0] = 1;
x[1] = 1;

for (int i = 2; i < n; i++)
{
    x[i] = x[i - 1] + x[i - 2];
}
Console.WriteLine($"Numarul de pe pozitia {n} din sirul lui Fibonacci este: {x[n - 1]}");

// Pana acum, pentru a repeta anumite instructiuni, am folosit for. Denumirea teoretica a unui for este
// "structura repetitiva cu numar cunoscut de pasi", asta pentru ca tot timpul folosim un indice / o valoare
// care incepe de la un numar, si se termina la valoarea din conditie ("i < n").
// Dar pentru situatiile cand nu stim de cate ori trebuie sa se execute instructiunea, nu mai putem folosi for.
// Vom folosi "structura repetitiva cu numar necunoscut de pasi", adica un "while".
// structura unui while este chiar mai simpla decat cea a unui for: while (conditie) { ... }
// De exemplu, vrem sa facem suma numerelor citite din consola, pana cand se introduce numarul 0 in consola.
int suma = 0;
numar = int.Parse(Console.ReadLine());

while (numar != 0)
{
    suma += numar;
    numar = int.Parse(Console.ReadLine());
}
Console.WriteLine(suma);

// Observam ca am scris "numar = int.Parse(Console.ReadLine());" de doua ori, o data inafara while-ului, si o data inauntru.
// Motivul pentru care am executat acea instrunctiune inafara while-ului, a fost pentru a ne asigura ca avem o valoare
// citita din consola inainte de conditia din while. Dar pentru ca operatia este exact aceeasi, putem folosi alt block
// repetitiv, care executa codul din interiorul sau cel putin o data: "do ... while" (intai ii spunem codului sa execute,
// si abia apoi punem conditia). Transformam codul precedent folosind do ... while:
suma = 0;
do
{
    numar = int.Parse(Console.ReadLine());
    suma += numar;

} while (numar != 0);

Console.WriteLine(suma);

// Calculati sumele primilor factoriali, pana cand valoarea sumei depaseste 1 000 000 000
long sumaFactorial = 0;
n = 1;
do
{
    factorial = 1;
    for (int i = 2; i <= n; i++)
    {
        factorial *= i;
    }
    sumaFactorial += factorial;
    n++;
} while (sumaFactorial < 1_000_000_000);

Console.WriteLine(sumaFactorial);

// Orice "for" se poate scrie sub forma de while foarte simplu: in loc de
// for (initial; conditie; final;) { ... }
// Putem scrie:
// initial;
// while (conditie) { ... final; }
//
// Dar nu* orice while se poate scrie sub forma de for (poate sa aiba si doar conditia)