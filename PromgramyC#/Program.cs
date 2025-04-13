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

        Console.WriteLine("Wybierz Opcje:");
        Console.WriteLine("1 - Przelicz Celsjusz na Fahrenheit");
        Console.WriteLine("2 - Przelicz Fahrenheit na Celsjusz");

        string wybor = Console.ReadLine();

            if(wybor== "1") {
                Console.Write("Podaj temperaturę w Celsjuszach: ");
                double tempC1 = Convert.ToDouble(Console.ReadLine());
                double tempF1 = tempC1 * 1.8 + 32;
                Console.WriteLine("Temperatura w Fahrenheitach: " + tempF1);

            } else if(wybor== "2") {
                Console.Write("Podaj temperaturę w Fahrenheitach: ");
                double tempF2 = Convert.ToDouble(Console.ReadLine());
                double tempC2 = (tempF2 - 32 )/ 1.8;
                Console.WriteLine("Temperatura w Celsjuszach: " + tempC2);
            } else {
                Console.WriteLine("Nieprawidłowy wybór!");
            }
        
    }


    static void SredniaOcen()
    { 
         Console.WriteLine("Hello World!");

    }

}

