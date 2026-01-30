// C# Enums
// An enum is a special "class" that represents a group of constants 
// (unchangeable/read-only variables).To create an enum, use the enum keyword 
// (instead of class or interface), and separate the enum items with a comma


class Program
{
    enum Level{
        Low,    //0
        Medium, //1
        High    //2
    }
    static void Main(string[] args)
    {
        Level myconst =  Level.Medium;
        //inorder to print integer value from an item, you must explicitly convert the item to an int 
        Console.WriteLine(myconst);
        int constnum = (int)Level.High;
        Console.WriteLine(constnum);

        //enum in switch
        Level myVar = Level.Medium;
        switch(myVar) 
        {
        case Level.Low:
            Console.WriteLine("Low level");
            break;
        case Level.Medium:
            Console.WriteLine("Medium level");
            break;
        case Level.High:
            Console.WriteLine("High level");
             break;
  }
}
}
