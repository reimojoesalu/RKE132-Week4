
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (lookActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.Writline($cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congrations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops. Try agin.");
    }
}

Console.WriteLine("Have a nice day!");