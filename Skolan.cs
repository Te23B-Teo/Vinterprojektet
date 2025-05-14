using System.ComponentModel.Design;

class Skolan
{
    public void Matte()
    {
        int life = 5;
        int poäng = 0;
        // listor för att lagra informationen för frågor och svar
        string[] frågor = { "Vad är den 12e bokstaven i alfabetet?", "Hur många kontinenter finns det?", "Hur många hjärtan har en bläckfisk?", "Hur många fingrar har fiskar?" };

        string[] rättaSvar = { "l", "7", "3", "0" };

        Console.WriteLine(@"Du är i skolan och ska gå på lektion och läraren har gett dig ett prov som du måste klara för att få gå ut på rasten.
        Du har 5 liv och du får 1 poäng för varje rätt svar du ger och minus 1 liv för varje fel svar.

PS: om du har fel så kan du förlora dina liv och om du får slut på liv så kommer du dö!!!");


        // en loop som skriver ut frågorna och ger möjlighet att svara på dem
        for (int i = 0; i < frågor.Length; i++)
        {
            Console.WriteLine(frågor[i]);
            string svar = Console.ReadLine();
            Console.Clear();
            if (svar == rättaSvar[i])
                poäng++;
            else
                life--;
        }
        // går vidare om man fick godkänt på provet
        if (life > 3)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Grattis, du klarade provet och fick {poäng} poäng av 4, vilket gjorde att du har {life} liv kvar.");
                Console.WriteLine("Tryck på enter för att fortsätta");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("Du har nu klarat av provet och går ut till korridoren där du träffar mobbare som försöker slå ner dig vill du hamna i en fight eller flyr du? svara ja om du vill slåss annars nej");

                string fight = Console.ReadLine();
                if (fight.ToLower() == "ja")
                {
                    Console.Clear();
                    int mc = life * 10;
                    int mobbare = 50;
                    bool fightloop = true;
                    while (fightloop)
                    {
                        Console.WriteLine("Grattis du valde att slåss mot mobbaren lycka till!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine($"Du har {mc} i attack och mobbaren har {mobbare} i liv");
                        Console.WriteLine("Tryck på enter för att attackera mobbaren");
                        Console.ReadLine();
                        while (fightloop)
                        {
                            Console.Clear();
                            Console.WriteLine($"Du har {mc} i liv och mobbaren har {mobbare} i liv.");

                            // Spelarens attack
                            int PDamage = Random.Shared.Next(5, 15);
                            mobbare -= PDamage;
                            Console.WriteLine($"Du attackerade mobbaren och gjorde {PDamage} skada!");
                            Thread.Sleep(1000);

                            // kollar om mobbaren förlorar
                            if (mobbare <= 0)
                            {
                                Console.WriteLine("Grattis! Du besegrade mobbaren!");
                                fightloop = false;
                                break;
                            }

                            // Mobbarens attack
                            int MDamage = Random.Shared.Next(5, 10);
                            mc -= MDamage;
                            Console.WriteLine($"Mobbaren attackerade dig och gjorde {MDamage} skada!");
                            Thread.Sleep(1000);

                            // Kollar om spelaren förlorar
                            if (mc <= 0)
                            {
                                Console.WriteLine("Tyvärr, mobbaren besegrade dig...");
                                fightloop = false;
                                break;
                            }
                            Console.WriteLine("Tryck på Enter för att fortsätta till nästa runda.");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
        // om man får för mycket fel så startas ditt spel om 
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