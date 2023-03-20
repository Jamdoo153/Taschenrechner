namespace Taschenrechner_Iteration_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren" Als Benutzer möchte zweit Zahlen eingeben, um die Summe berechnen lasen.
            Console.Write("Bitte gebe die erste Zahl ein: ");
            string ersteZahl = Console.ReadLine();
            Console.Write("Bitte gebe die zweite Zahl ein: ");
            string zweiteZahl = Console.ReadLine();

            // wandel Text in Ganzzahl
            int ersteSummenAlsZahl1 = Convert.ToInt32(ersteZahl);

            int summe = ersteSummenAlsZahl1 + zweiteSummenAlsZahl1;
            Console.WriteLine("Das Ergebnis aus {0} + {1} = {2}", ersteZahl, zweiteZahl, summe);
            Console.ReadKey();
        }
    }
}