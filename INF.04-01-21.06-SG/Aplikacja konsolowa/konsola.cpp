#include <iostream>
using namespace std;

class tablica {
    private:
        int tab[10];
        /********************************************************
        * nazwa funkcji:        znajdzNajwieksza
        * parametry wejściowe:  Brak
        * wartość zwracana:     Funkcja znajduje nawiększą z liczb podanych przez użytkownika w stosie "tab" 
        * autor:                000000000000
        * ****************************************************/
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
        /********************************************************
        * nazwa funkcji:        wczytaj
        * parametry wejściowe:  Brak
        * wartość zwracana:     Funkcja pobiera od użytkownika 10 liczb całkowitych i przechowuje je w stosie o nazwie "tab"
        * autor:                000000000000
        * ****************************************************/
        void wczytaj()
        {
            cout << "Wypisz 10 liczb calkowitych: \n";
            for (int i = 0; i < 10; i++)
            {
                cin >> tab[i];
            }
            cout << "\nNajwieksza liczba z wypisanych jest: " << znajdzNajwieksza() << "\n";
        }
        /********************************************************
        * nazwa funkcji:        sortuj
        * parametry wejściowe:  Brak
        * wartość zwracana:     Funkcja sortuje liczby podane wcześniej przez użytkownika a następnie je wypisuje
        * autor:                000000000000
        * ****************************************************/
        void sortuj()
        {
            for (int i = 0; i < 10 - 1; i++) {
                for (int j = 0; j < 10 - i - 1; j++) {
                    if (tab[j] > tab[j + 1]) {
                        swap(tab[j], tab[j + 1]);
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


