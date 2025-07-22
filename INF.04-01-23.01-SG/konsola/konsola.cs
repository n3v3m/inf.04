using System;

class Program
{
    static void Main() {
        int a, b;

        Console.WriteLine("Wpisz pierwszą liczbe:");
        while (!int.TryParse(Console.ReadLine(), out a)) {
            Console.WriteLine("Wpisz poprawną liczbę całkowitą: ");
        }

        Console.WriteLine("Wpisz drugą liczbe:");
        while (!int.TryParse(Console.ReadLine(), out b)) {
            Console.WriteLine("Wpisz poprawną liczbę całkowitą: ");
        }

        int c = AlgorytmEuklidesa(a, b);

        Console.WriteLine("Wynik działania algorytmu: " + c);
    }

    static int AlgorytmEuklidesa(int a, int b) {
        while (a != b) {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }

        return a;
    }
}


