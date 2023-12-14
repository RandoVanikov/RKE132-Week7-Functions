
//userInput == Argument
//anyString == parameter


Console.WriteLine("Enter a word:");

String userInput = Console.ReadLine();

PrintAnyWord(userInput); 

static void PrintAnyWord(string anyString)
{
   anyString = anyString.ToUpper();
    for(int i = 0; i < 5 ; i++)
    {
        Console.WriteLine(anyString);
    }
}