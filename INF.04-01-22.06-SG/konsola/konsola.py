import random
random.seed()

class Algorytm:

    def __init__(self, dlugosc, szukana):    
        self.tablica = [0] * ( dlugosc + 1 )
        self.dlugosc = dlugosc
        self.szukana = szukana

    def wczytaj(self):
        print('Twoja tablica: ')
        for i in range(self.dlugosc):
            self.tablica[i] = int(random.random()*100)
            print(self.tablica[i])
        self.tablica[self.dlugosc] = self.szukana

    def szukaj(self):
        for i in range(self.dlugosc):
            if (self.tablica[i] == self.szukana):
                return i;
        return self.dlugosc;



n = 51  # dlugosc tablicy

x = int(input('Podaj wartość którą chcesz wyszukać '))
a1 = Algorytm(n, x)

a1.wczytaj()

index = a1.szukaj()

if (index == n):
    print('Twoja liczba: nie została znaleziona w tym zbiorze')
else:
    print('Twoja liczba została znaleziona na miejscu: ' + str(index))