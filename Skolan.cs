class Skolan
{
    public void Matte()
    {
        int life = 5;
        int poäng = 0;
        // listor för att lagra informationen för frågor och svar
        string[] frågor = {"Vad är den 12e bokstaven i alfabetet?","Hur många kontinenter finns det?","Hur många hjärtan har en bläckfisk?","Hur många fingrar har fiskar?"};

        string[] rättaSvar = { "l", "7", "3", "0"};

        Console.WriteLine(@"Du är i skolan och ska gå på lektion

Du har prov och den första frågan är: Vad är den 12e bokstaven i alfabetet?

    PS: om du har fel så kan du förlora dina liv och om du får slut på liv så kommer du dö!!!");

    // en loop som skriver ut frågorna och ger möjlighet att svara på dem
        for (int i = 0; i < frågor.Length; i++)
        {
            Console.Clear();
            Console.WriteLine(frågor[i]);
            string svar = Console.ReadLine();
            if (svar == rättaSvar[i])
                poäng++;
            else
                life--;
        }
    // gör alternativen för hur man har svarat på frågorna
        if (life > 3)
        {
            while(true){
            Console.Clear();
            Console.WriteLine($"Grattis, du klarade provet och fick {poäng} poäng av 4, vilket gjorde att du har {life} liv kvar.");
            Console.WriteLine("Tryck på enter för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Du har nu klarat av provet och går ut till korridoren där du träffar mobbare som försöker slå ner dig vill du hamna i en fight eller flyr du? svara ja om du vill slåss annars nej");
            string mobbare = Console.ReadLine();
            if(mobbare.ToLower() == ""){

            }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(@"Tyvärr fick du alla fel, vilket gjorde att alla dina liv är slut och du dog!!!
            
            Tryck på Enter för att starta om spelet.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}