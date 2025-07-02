var numberString = string.Empty;
do
{
    Console.Write("Inserire un numero intero o la parola 'Uscire' per uscire: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "uscire")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"Il numero inserito, {numberInt}, è pari!");
        }
        else
        {
            Console.WriteLine($"Il numero inserito, {numberInt}, è dispari!");
        }
    }
    else
    {
        Console.WriteLine($"Quello inserito, {numberString}, non è un numero intero!");
    }
    
}while (numberString!.ToLower() != "uscire");
Console.WriteLine("Game Over.");


