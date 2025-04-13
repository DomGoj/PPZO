def kalkulator():
    liczba1= float(input("Podaj pierwsza liczbe: "))
    liczba2= float(input("Podaj druga liczbe: "))
    operator= input("Podaj operator (+, -, *, /)")

    if operator == "+":
        wynik= liczba1 + liczba2
    elif operator == "-":
        wynik= liczba1 - liczba2
    elif operator == "*":
        wynik= liczba1 * liczba2
    elif operator == "/":
        if liczba2 != 0:
            wynik= liczba1 / liczba2
        else:
            return "Nie mozna dzielic przez zero"
    else:
        return "Niepoprawny operator"
    return f"Wynik: {wynik}"

def KonwerterTemperatur():
    print("zad2")

def SredniaOcen():
    print("zad3")

def main():
    print("Wybierz zadanie od 1-3")
    print("1. Prosty kalkulator dwóch liczb")
    print("2. Konwerter temperatur (Celsjusz ↔ Fahrenheit)")
    print("3. Średnia ocen ucznia")
    wybor = input()
    
    if wybor == "1":
        print(kalkulator())
    elif wybor == "2":
        print(KonwerterTemperatur())
    elif wybor == "3":
        print(SredniaOcen())
    else:
        print("Nieprawidłowy wybór!")
        
if __name__ == "__main__":
    main()