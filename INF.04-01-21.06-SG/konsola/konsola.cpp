#include <iostream>
using namespace std;

class tablica {
    private:
        int tab[10];

        int znajdzNajwieksza()
        {
            int najwiekszaLiczba = tab[0];

            for (int i = 0; i < 10; i++) 
            {
                if (tab[i] > tab[najwiekszaLiczba])
                {
                    najwiekszaLiczba = i;
                }    
            }

            return tab[najwiekszaLiczba];
        }
    public:

        void wczytaj()
        {
            cout << "Wypisz 10 liczb calkowitych: \n";
            for (int i = 0; i < 10; i++)
            {
                cin >> tab[i];
            }
            cout << "\nNajwieksza liczba z wypisanych jest: " << znajdzNajwieksza() << "\n";
        }

        void sortuj()
        {
            for (int i = 0; i < 10; i++) {
                for (int j = i; j < 10; j++) {
                    if (tab[i] > tab[j]) {
                        swap(tab[i], tab[j]);
                    }
                }
            }

            cout << "Posortowana tablica: \n";
            for (int i = 0; i < 10; i++)
                cout << tab[i] << "\n";
        }
};

int main()
{
    tablica t1{};

    t1.wczytaj();
    
    t1.sortuj();

    return 1;   
}


