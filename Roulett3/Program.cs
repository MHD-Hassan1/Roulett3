
Random rand = new Random();

Console.WriteLine("Welcome to Roulette!!");

Console.WriteLine("How much is ur budget"); 
int budget = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("And how much do u want to bet today :)");
int bet = Convert.ToInt32(Console.ReadLine());

if  (budget < bet)
{
    Console.WriteLine(" U dont have so much money :(");
}