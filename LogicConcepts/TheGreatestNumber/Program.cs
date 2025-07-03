var numberString = string.Empty;
do
{
    var controllo = true;

    Console.WriteLine("Inserire tre numeri interi differenti");
    
    var numberInt = 0;
    var a = 0;
    var b = 0;
    var c = 0;

    do
    {
        Console.Write("Inserire il primo numero   : ");
        numberString = Console.ReadLine();
        if (int.TryParse(numberString, out numberInt))
        {
            a = numberInt;
            controllo = true;
        }
        else
        {
            Console.WriteLine($"Quello inserito, {numberString}, non è un numero intero!");
            controllo = false;
        }
    } while (controllo != true);

    do
    {
        Console.Write("Inserire il secondo numero : ");
        numberString = Console.ReadLine();
        if (int.TryParse(numberString, out numberInt))
        {
            b = numberInt;
            controllo = true;
        }
        else
        {
            Console.WriteLine($"Quello inserito, {numberString}, non è un numero intero!");
            controllo = false;
        }
    } while (controllo != true);

    do
    {
        Console.Write("Inserire il terzo numero   : ");
        numberString = Console.ReadLine();
        if (int.TryParse(numberString, out numberInt))
        {
            c = numberInt;
            controllo = true;
        }
        else
        {
            Console.WriteLine($"Quello inserito, {numberString}, non è un numero intero!");
            controllo = false;
        }
    } while (controllo != true);
    

    if (a > b && a > c)
    {
        Console.WriteLine($"Il numero maggiore è: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"Il numero maggiore è: {b}");
    }
    else
    {
        Console.WriteLine($"Il numero maggiore è: {c}");
    }

    Console.Write("Per chiudere il programma digitare uscire altrimenti premere il tasto invio per continuare: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "uscire")
    {
        continue;
    }
} while (numberString!.ToLower() != "uscire");
Console.WriteLine("Game Over.");
