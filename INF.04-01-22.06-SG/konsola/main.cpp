

#include <iostream>
#include <cstdlib>
#include <ctime> 

using namespace std;

class algorytm {
private:
    int tab[];
public:
    void wczytaj(int x, int n)
    {
        srand(time(0));
        std::cout << "Twoja tablica: ";
        for (int i = 0; i < n; i++)
        {
            tab[i] = std::rand() % 101;
            std::cout << tab[i] << ", ";
        }
        tab[n] = x;
    }

    int szukaj(int x, int n)
    {

        for (int i = 0; i < n; i++)
        {
            if (tab[i] == x) {
                return i;
            }
        }

        return n;
    }
};

int main()
{
    algorytm a1{};

    int x;

    const int n = 51; // d³ugoœæ tablicy

    std::cout << "Wpisz liczbe z zakresu od 1 do 100 ktora chcesz wyszukac: \n";
    std::cin >> x;

    a1.wczytaj(x, n);
    int index = a1.szukaj(x, n);

    if (index == n) {
        std::cout << "\nTwoja liczba nie zostala znaleziona w tym zbiorze";
    }
    else {
        std::cout << "\nTwoja liczba zostala znaleziona na miejscu: " << index;
    }

    return 1;
}