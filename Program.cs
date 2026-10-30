namespace AS2627._3F.MarioBuononato.totaleIrpef;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MarioBuononato.3F.29/10/26.a casa");
        Console.WriteLine("l'utente mettendo il suo reddito lordo scopre a quanto corrisponde il suo reddito netto");
        Console.WriteLine("scopre anche quant'è il guadagno per ogni scaglione");

        double redLordo,totaleIrpef,redNetto;
        double scaglione1=0;
        double scaglione2=0;
        double scaglione3=0;

        Console.WriteLine("Inserisci il tuo reddito personale (non tassato): ");
        if (double.TryParse(Console.ReadLine(), out redLordo))
        {
            if (redLordo <= 28000)
            {
                // reddito minore ai 28k quindi si applica 23%
                scaglione1 = redLordo * 0.23;
            }
            else if (redLordo <= 50000)
            {
                // reddito minore ai 50k quindi si applica anche 33%
                scaglione1 = 28000 * 0.23;
                scaglione2 = (redLordo - 28000) * 0.33;
            }
            else
            {  
                // reddito maggiore ai 50k quindi si applica anche 43%
                scaglione1 = 28000 * 0.23;
                scaglione2 = 22000 * 0.33;
                scaglione3 = (redLordo-50000) * 0.43;
            }
            // l'IRPEF = somma tutti gli scaglioni
            totaleIrpef = scaglione1+scaglione2+scaglione3;
            redNetto = redLordo-totaleIrpef;
            Console.WriteLine($"\nIRPEF = {totaleIrpef:F2}€;\nIl reddito netto = {redNetto:F2}€;\n");
            Console.WriteLine($"il primo scaglione = {scaglione1:F2}€;\n");
            Console.WriteLine($"il secondo scaglione = {scaglione2:F2}€;\n");
            Console.WriteLine($"il terzo scaglione = {scaglione3:F2}€.\n");
        }
        else Console.WriteLine("Errore: Valore inserito non valido");
    }
}
