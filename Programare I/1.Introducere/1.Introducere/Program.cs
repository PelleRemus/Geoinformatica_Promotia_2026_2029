// Pentru a scrie text in consola (caseta text), trebuie sa folosim clasa "Console",
// Si apelam functia / metoda "WriteLine", adica ii cerem sa scrie o linie de text.
// La finalul textului, se trece pe linia urmatoare. Apelul unei functii se incepe cu un set de paranteze ().
// Intre cele doua paranteze, se afla parametrii, iar in cazul functiei WriteLine, avem unul singur,
// textul ce vrem sa fie afisat. Textul trebuie scris intre ghilimele.
Console.WriteLine("Hello, World!");

// La finalul liniilor de cod finale / complete, se pune ";" pentru a-i spune codului ca suntem la finalul instructiunii curente
// Console.WriteLine("Hello, World!")      // da eroare: "; expected"

// Un comentariu incepe in momentul in care adaugam doua slash-uri "//". In c#, comentariile sunt scrise cu verde.
// Comentariile sunt practic caractere goale, adica codul le va ignora la executie (nu incearca sa le execute ca pe instructiuni)
/*
 * Se pot defini si comentarii pe mai multe linii. Acestea incep cand scriem "/*" si se finalizeaza cand scriem "*", apoi "/".
 */

// Functia Write afiseaza text, fara sa treaca pe linia urmatoare la final. Deci codul de mai jos afiseaza:
// Hello, World! aceeasi linie
Console.Write("Hello, ");
Console.Write("World!");
Console.WriteLine(" aceeasi linie");

// Se pot afisa si numere in mod direct, fara a folosi ghilimele, pentru ca interpretarea numerelor de catre cod functioneaza
Console.WriteLine(23);

// Se pot face si operatii aritmetice simple, cum ar fi adunarea "+", scaderea "-", inmultirea "*" si impartirea "/"
Console.WriteLine(2 * 5 + 6 / 3 - 1);

// Putem folosi si paranteze pentru a schimba ordinea operatiilor. Daca avem doua seturi de paranteze una in alta,
// nu trecem de la paranteze rotunde "()" la paranteze drepte "[]". Se folosesc doar paranteze rotunde "()"
Console.WriteLine(2 * ((5 + 6) / (3 - 1)));

// Pentru a avea si numere cu virgula, trebuie doar sa scriem, de exemplu "5.0", pentru a-i spune codului
// ca vrem sa folosim numere cu virgula
Console.WriteLine(2 * ((5.0 + 6) / (3 - 1)));

// Nu intotdeauna vom avea nevoie sa afisam direct text sau rezultate de la calcule. Pentru a nu pierde aceste valori,
// trebuie sa le salvam cu un anumit nume / o anumita eticheta. Acest nume va fi defapt numele unei Variabile.
// Variabilele permit stocarea datelor pentru a fi folosite si refolosite, modificate etc pe parcursul executarii codului.
// Pentru text, tipul de variabila va fi "string". O variabila se defineste scriind tipul acesteia si numele variabilei.
string nume;

// Pentru a da valoare unei variabile, folosim numele acesteia, urmat de "=", si apoi de valoarea pe care vrem sa i-o atribuim
nume = "Remus";

// Pentru afisare, trebuie sa scrie direct numele variabilei, fara a fi intre ghilimele
Console.WriteLine(nume);

// Se pot face operatii si cu text. Cea mai utila / folosita la inceput este operatia de Concatenare,
// care este practic alipire. In cod este doar un "+" intre doua valori text.
// Ex: "Hello " + "World" = "Hello World"
// Ex: "5" + "6" = "56"
Console.WriteLine("Hello, " + nume + "!");

// Pentru numere, exista mai multe tipuri de variabile, in functie de ce numar este. Cele mai utile sunt
// "int" pentru numere intregi / naturale, "double" pentru numere cu virgula (numere reale)
// O variabila se poate declara si poate primi valoare pe aceeasi linie: <tip> <nume> = <valoare>;
int numar = 12;
Console.WriteLine("Numarul ales: " + numar);

// Se pot face si operatii cu variabila
Console.WriteLine(numar * 5);

// Se poate si modifica valoare variabilei, folosind din nou numele, "=" si valoarea noua
numar = numar / 3;
Console.WriteLine(numar);

// Se pot face si operatii intre mai multe variabile.
// Se pot declara si se pot initializa (pot primi valori) mai multe variabile pe aceeasi linie, daca au acelasi tip de date,
// daca acestea sunt separate prin virgula: <tip> <nume1> = <valoare1>, <nume2>, <nume3> = <valoare3>;
double x = 2, y = 5.0, z = 6;
Console.WriteLine(x * y / z);

// De obicei, este bine sa venim cu denumiri mai lungi pentru variabile, pentru a "explica" care este rolul acesteia.
// Ajuta pentru a putea citi mai usor / natural codul. Cand denumirea este formata din mai multe cuvinte, conventia este
// sa se foloseasca in C# camelCase: primul cuvant incepe cu litera mica, dar restul dupa aceea incep cu litera mare
int numarCuNumeInStilCamelCase = 50;

// Pana acum, am aratat cum se afiseaza in consola, dar daca avem nevoie de valori pe care sa le decidem doar dupa executia programului,
// Putem inclusiv "citi de la tastatura" (citi din consola). Folosim functia "ReadLine()".
nume = Console.ReadLine();
Console.WriteLine("Hello, " + nume);

// Tot ceea ce citim prin ReadLine, va fi sub forma de text, deci nu poate fi folosit decat pentru variabile string.
// Pentru a salva valoarea in variabile de tip numar (int, double, etc), trebuie facuta o conversie
// int nr = Console.ReadLine();     // eroare: "Cannot implicitly convert type 'string' to 'int'