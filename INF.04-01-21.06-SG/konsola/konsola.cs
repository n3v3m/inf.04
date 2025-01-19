using System;

class Tablica
{
    private int[] tab = new int[10];

    private int ZnajdzNajwieksza()
    {
        int najwiekszaLiczba = tab[0];

        for (int i = 1; i < 10; i++)
        {
            if (tab[i] > najwiekszaLiczba)
            {
                najwiekszaLiczba = tab[i];
            }
        }
        return najwiekszaLiczba;
    }

    public void Wczytaj()
    {
        Console.WriteLine("Wypisz 10 liczb calkowitych:");
        for (int i = 0; i < 10; i++)
        {
            tab[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"\nNajwieksza liczba z wypisanych jest: {ZnajdzNajwieksza()}\n");
    }

    public void Sortuj()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (tab[i] > tab[j])
                {
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                }
            }
        }

        Console.WriteLine("Posortowana tablica:");
        foreach (int liczba in tab)
        {
            Console.WriteLine(liczba);
        }
    }
}

class Program
{
    static void Main()
    {
        Tablica t1 = new Tablica();

        t1.Wczytaj();
        t1.Sortuj();
    }
}