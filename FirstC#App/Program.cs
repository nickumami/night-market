const int nightMarketTime = 9;

Console.WriteLine("    This is the start of the shop \n");
DateTime todaysDate = DateTime.Now;
Console.WriteLine("====== " + todaysDate.ToLongDateString() + " ======");
Console.WriteLine("====== " + todaysDate.Date + " ======\n");

//Ask user their age to see if they can see the night martket alongside the tim
Console.WriteLine("What's your age ? There might be a surprise for the right age and time");
string inputAge = Console.ReadLine();

//check time and age 
if (todaysDate.Hour > 3 && Int32.Parse(inputAge) > 18)
{
    Console.WriteLine("NIGHT MARKET LIVE UNTIL 3AM\n");

    //write a night market function once we learn functions 
}
else
{
    Console.WriteLine("Nevermind normal market :(\n");
    //write a normal market function once we have functions unlocked 
}



Console.WriteLine("");
