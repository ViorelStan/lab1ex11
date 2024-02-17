/*
 * Folosind instructiunea "switch", scrieti un program care citind de la tastatura
 * un numar intreg va verifica urmatoarele
 * - "unu" daca numarul intreg este 1
 * - "doi" daca numarul intreg este 2
 * - "trei" daca numarul intreg este 3
 * - "cinci" daca numarul intreg este 5
 * - "opt" daca numarul intreg este 8
 * - "neidentificat" pentru orice alt caz
*/

using System.ComponentModel;

Console.WriteLine("Introduceti numarul pe care doriti sa il verificam");
int numar = int.Parse(Console.ReadLine());

switch (numar)
{
    case 1: Console.WriteLine("unu");
        break;
    case 2: Console.WriteLine("doi");
        break;
    case 3: Console.WriteLine("trei");
        break;
    case 5: Console.WriteLine("cinci");
        break;
    case 8: Console.WriteLine("opt");
        break;
    default:
        Console.WriteLine("neidentificat");
        break;
}