class Tablica:

    def __init__(self):    
        self.tablica = [0] * 10 

    def __znajdzNajwieksza(self):
        self.najwiekszaLiczba = 0
        for i in range(10):
            if (self.tablica[i] > self.najwiekszaLiczba):
                self.najwiekszaLiczba = self.tablica[i]
            

        return str(self.najwiekszaLiczba)

    def wczytaj(self):
        print("Wypisz 10 liczb calkowitych: \n")
        for i in range(10):
            self.tablica[i] = int(input())
        print("Najwieksza liczba z wypisanych jest: " + self.__znajdzNajwieksza())

    def sortuj(self):
        for i in range(10):
            for j in range(10):
                if (self.tablica[i] > self.tablica[j]):
                    self.tablica[i], self.tablica[j] = self.tablica[j], self.tablica[i]
        print("Posortowana tablica: ")
        for i in range(10):
            print(str(self.tablica[i])+', ')

tab = Tablica()

tab.wczytaj()

tab.sortuj()