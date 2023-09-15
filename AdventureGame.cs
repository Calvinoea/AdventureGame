// Print backstory to user

Console.WriteLine("Welcome to the Zone");
Console.WriteLine("You are a new professional sports team owner in the Utopia Sports League");
Console.WriteLine("Now that you are the new onwer of a group of teams, you decide to take a look inside.");
Console.WriteLine("Your newly owned sportsgrounds look good but there's been rumours of them being booby trapped by the former owners who you bought out");
Console.WriteLine("Do you want to check out the club houses?");


// Prompt user for choice

Console.Write("> ");
String houseChoice = Console.ReadLine();


// Ask player which club house they want to go to

if(houseChoice == "baseball team")
{

    Console.WriteLine("You chose to go to the club house of the baseball team");
    Console.WriteLine("As you walk in, you see a lion in the club house");
    Console.WriteLine("You see a jar of sleeping gas next to you. Use the sleeping gas?");


    Console.Write("> ");
    String lionChoice = Console.ReadLine();

    if (lionChoice == "yes")
    {
        Console.WriteLine("You attempt to use the sleeping gas. The lion is too strong. It bounces back and rips you apart. ");
        Console.WriteLine("You nearly die but a groundskeeper is able to drag you away and takes you to hospital :(");

    }
    else if (lionChoice == "no")
    {
        Console.WriteLine("You decide to run as far as possible with the speed of Usain Bolt");
        Console.WriteLine("You find your way out of the clubhouse and call animal rescue");
    } else
    {
        Console.WriteLine("Please answer yes or no");
    }

} else if(houseChoice == "football team")
{
    Console.WriteLine("You chose to go to the club house of the football team");
    Console.WriteLine("As you walk in, you see a shiny championship cup. The quintilla cup :)");
    Console.WriteLine("Do you want to lift it up and kiss it?");

    // Prompt the user for a choice

    Console.Write("> ");
    string cupChoice = Console.ReadLine();

    if (cupChoice == "yes")
    {
        Console.WriteLine("You lift the cup and feel the ground shake as UEFA Champions League music starts to play")
    }

    else if (cupChoice == "no")
    {
        Console.WriteLine("You act like a chicken and nothing happens. Suddenly an alarm goes off.");
        Console.WriteLine("You've been standing in the same spot which triggers off an alarm");
        Console.WriteLine("You should have gone to Specsavers");
    }else
    {
        Console.WriteLine("Please answer yes or no");
    }
}
else {
    Console.WriteLine("Please answer between the teams");
}
