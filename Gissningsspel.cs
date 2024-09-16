Random random = new Random();
int randomNummer =  random.Next(1, 101);

int antalGissningar = 0, gissningsNummer = -1; 
Console.WriteLine("Gissa vilket nummer jag valt 1-100: ");

while (gissningsNummer != randomNummer){
    gissningsNummer = int.Parse(Console.ReadLine());
    if (gissningsNummer < randomNummer){ 
        Console.WriteLine("Fel. Ditt nummer är för lågt!");
    }
    if (gissningsNummer > randomNummer){ 
        Console.WriteLine("Fel. Ditt nummer är för högt!");
    }
        antalGissningar++; 
}

Console.WriteLine("Rätt!");
Console.WriteLine("Du använde " + antalGissningar + " gissning(ar)!");