using System.Security.Cryptography.X509Certificates;

namespace Oppgave_uke_1;
class Program
{
    // Fasit oppgave 2
    static void Main(string[] args)
    {
        int myInt = 5;
        Console.WriteLine(myInt);
        string myString = "Hello World!";
        Console.WriteLine(myString);
        double myDouble = 5.5;
        Console.WriteLine(myDouble);
        char myChar = 'O';
        Console.WriteLine(myChar);
        int[] myIntArray = {1,2,3,4,5,6,7,8,9,10};

        for(int i = 0; i < myIntArray.Count(); i++) 
        {
            Console.WriteLine(myIntArray[i]);
        }

        string[] myStringArray = {"Hello", "From", "A", "C#", "Array!"};
        foreach(string myStrings in myStringArray) 
        {
            Console.WriteLine(myStrings);
        }

        List<string> myList = new List<string>();

        myList.Add("Hello");
        myList.Add("From");
        myList.Add("A");
        myList.Add("C#");
        myList.Add("List");
        foreach(string strings in myList) 
        {
            Console.WriteLine(strings);
        }

        // Fasit Oppgave 3
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        myDictionary.Add(1, "Value 1");
        myDictionary.Add(2, "Value 2");

        foreach(var keyvaluepair in myDictionary) 
        {
            Console.WriteLine(keyvaluepair);
        }

        Console.WriteLine(AddNumbers(5,5));
        Console.WriteLine(SayHello("Jorgen"));

        double MyDoubleMethod(int a, double b) 
        {
            return a + b;
        }
        Console.WriteLine(MyDoubleMethod(3,2.5));

        string MyStringMethod(string message) 
        {
            return message;
        }
        Console.WriteLine(MyStringMethod(" "));
    }

    static public int AddNumbers(int a, int b) 
    {
        return a + b;
    }

    static public string SayHello(string greeting) 
    {
        return "Hello there " + greeting + "!";
    }
}
