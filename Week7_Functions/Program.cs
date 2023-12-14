
Console.WriteLine("Are you here? (yes/no):");
string userChoice = Console.ReadLine();

if(userChoice == "yes")
{
    PrintHello();

}
else
{
    PrintGoodBye();
}


static void PrintHello()
{

Console.WriteLine("Hello, World!");

}



static void PrintGoodBye()
{
    Console.WriteLine("Good bye, see you later!");

}