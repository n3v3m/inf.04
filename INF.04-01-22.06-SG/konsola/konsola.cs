using System;

class Algorytm
{
    private int[] tab;

    public Algorytm(int n)
    {
        tab = new int[n];
    }

    public void Wczytaj(int n)
    {
        Random random = new Random();
        Console.WriteLine("Twoja tablica:");
        for (int i = 0; i < n; i++)
        {
            tab[i] = random.Next(0, 101);
            Console.Write(tab[i] + ", ");
        }
        Console.WriteLine();
    }

    public int Szukaj(int x, int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (tab[i] == x)
            {
                return i;
            }
        }
        return n;
    }
}

class Program
{
    static void Main()
    {
        const int n = 51; // Długość tablicy
        Algorytm a1 = new Algorytm(n);

        Console.WriteLine("Wpisz liczbe z zakresu od 1 do 100 ktora chcesz wyszukac:");
        int x = int.Parse(Console.ReadLine());

        a1.Wczytaj(n);
        int index = a1.Szukaj(x, n);

        if (index == n)
        {
            Console.WriteLine("\nTwoja liczba nie zostala znaleziona w tym zbiorze.");
        }
        else
        {
            Console.WriteLine($"\nTwoja liczba zostala znaleziona na miejscu: {index}");
        }
    }
}