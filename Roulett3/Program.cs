
Random rand = new Random();
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Welcome to Roulette!!");

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("How much is ur budget"); 
int budget = Convert.ToInt32(Console.ReadLine());
Console.Clear();

while (budget > 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Your current budget: {budget}" + "$");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("How much do you want to bet");
    int bet = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (bet > budget)
    {
    
        Console.WriteLine("Get the fuck out of here. Nigga boy");
        
    }

    Console.WriteLine("Do you want to bet on red or black?");
    string choice = Console.ReadLine();
    int number = rand.Next(0, 37);
    string color;
}





// Förenklad regel udda = röd, jämn = svart 0 = grönt




if (number == 0)
{
    color = "green";
} else if (number % 2 == 0 )
{
    color = "svart";
}
else
{
    color = "red";
}



