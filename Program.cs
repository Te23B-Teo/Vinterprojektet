﻿// till skolan där man räknar matte fel du dör eller nåt
class Program
{
    static void Main()
    {
        bool menybool = true;
        bool insbool = true;
        // Skapar en meny för koden och skapar en loop för att man ska kunna komma tillbaka
        while (menybool)
        {
            Console.WriteLine(@"Välkommen till Mysteriet i den Försvunna Staden!

Skriv start om du vill börja
Skriv av om du vill stänga av
Skriv inv om du vill öppna inventory
Skriv ins om du vill visa instruktionerna");

            string svar = Console.ReadLine();
            // kollar om svaret användaren svarar är för att starta spelet
            if (svar.ToLower() == "start")
            {
                Console.Clear();
                Math matte = new Math();
                matte.skolan();
            }
            // kollar om användaren vill stänga av spelet och stänger av den
            else if (svar.ToLower() == "av")
            {
                for (int i = 1; i < 3; i++)
                {
                    Console.Clear();
                    Console.Write("Loading");

                    for (int j = 1; j < 4; j++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    for (int l = 1; l < 4; l++)
                    {
                        Console.SetCursorPosition(11 - l, 0);
                        Console.Write(" ");
                        Thread.Sleep(500);
                    }
                }
                break;
            }
            else if (svar.ToLower() == "inv")
            {
                Console.Clear();
                break;
            }
            else if (svar.ToLower() == "ins")
            {
                while (insbool)
                {
                    Console.Clear();
                    Console.WriteLine(@"Det kommer finnas checkpoints på olika ställen där du kan öppna din meny för att komma åt att stänga av, inventory och instruktionerna.
Detta kommer att vara ett interaktivt storyspel där du försöker överleva livet i den Försvunna Staden!

Skriv 'back' för att komma tillbaka till startsidan.");

                    string BackFromIns = Console.ReadLine();
                    if (BackFromIns.ToLower() == "back")
                    {
                        Console.Clear();
                        insbool = false;
                    }
                }
                insbool = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"'{svar}' är inte ett alternativ!");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}


// // meny
// Console.WriteLine("Vällkommen till Mysteriet i den Försvunna Staden!");
// Console.WriteLine("");
// Console.WriteLine("Skriv start om du vill börja");
// Console.WriteLine("skriv av om du vill stänga av");
// Console.WriteLine("skriv inv om du vill öppna inventory");
// while (true) {

// string menyval = Console.ReadLine();
// if(menyval.ToLower() == "start"){

// }
// else if(menyval.ToLower() == "av"){
//     break;
// }








// else if(menyval.ToLower() == "sigma") {
//     Console.WriteLine("Startar spelet i sigma mode");
//     string[] sigmas = ["Oscar", "Teo", "Elis", "Anton"];

//     for (int i = 0; i < sigmas.Length; i++)
//     {
//         Console.WriteLine(i+1 + $". {sigmas[i]}");
//     }
//     Console.WriteLine("Välj din Hjälte!");
//     int choice;
//     while(!int.TryParse(Console.ReadLine(), out choice)) Console.WriteLine("Skriv ett nummer!");

//     choice -=1;
//     Console.WriteLine($"Du valde {sigmas[choice]}");


// }
// }







// Console.ReadLine();
// }

// Player p1 = new();
// Player p2 = new();

// p1.Name = "dnenfjenf";

// p2.Hitpoints -= 30;
// Console.WriteLine(p1.Hitpoints);

// Player p = new();

// Console.WriteLine(p.Name);
// Fight(p1
// Console.ReadLine();

// static void Fight(Player p){
//     Console.WriteLine(p.Name);
// }

// class Player
// {
// public string Name = "Micke";
// public int Hitpoints = 100;
// public int WeponDamage = 5;
// }