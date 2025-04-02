// class Math{
//     public string dadwa;

// public void cool(string dadwa){
//     this.dadwa = "jdjd";
//     Console.WriteLine(dadwa);
// }

// }

class Math
{
    public void skolan()
    {
        int life = 3;
        Console.WriteLine(@"Du är i skolan och ska gå på lektion

Du har prov och den första frågan är: Vad är första bokstaven i alfabetet?
        ");
        string svar1 = Console.ReadLine();

        if (svar1.ToLower() == "a")
        {
            Console.WriteLine("Rätt svar!");
        }
        else
        {
            life -= 1;
            Console.WriteLine("Fel! Liv kvar: " + life);
        }
    }
}
