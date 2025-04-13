using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz zadanie od 1-3:");
        Console.WriteLine("1 - Prosty kalkulator dwóch liczb");
        Console.WriteLine("2 - Konwerter temperatur (Celsjusz ↔ Fahrenheit)");
        Console.WriteLine("3 - Średnia ocen ucznia");

        string wybor = Console.ReadLine();

        switch (wybor)
        {
            case "1":
                Kalkulator();
                break;
            case "2":
                KonwerterTemperatur();
                break;
            case "3":
                SredniaOcen();
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór!");
                break;
        }
    }

    static void Kalkulator()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz działanie (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik = 0;

        if (operacja == "+")
        {
            wynik = liczba1 + liczba2;
        }
        else if (operacja == "-")
        {
            wynik = liczba1 - liczba2;
        }
        else if (operacja == "*")
        {
            wynik = liczba1 * liczba2;
        }
        else if (operacja == "/")
        {
            if (liczba2 != 0)
            {
                wynik = liczba1 / liczba2;
            }
            else
            {
                Console.WriteLine("Błąd: Dzielenie przez zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowa operacja!");
            return;

        }
        Console.WriteLine("Wynik: " + wynik);
    }

    static void KonwerterTemperatur()
    { 

         Console.WriteLine("Hello World!");
    }


    static void SredniaOcen()
    { 
         Console.WriteLine("Hello World!");

    }

}

