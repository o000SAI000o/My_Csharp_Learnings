//Interfaces
// Another way to achieve abstraction in C#, is with interfaces.
// An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):
//in c#, interface can have non regular methods as well

//interface
interface Animal{
    void animalsound(); // abstract method(by default public + abstract)
    public void sleep(){
        Console.WriteLine("Zzz...Zz...");
    }
}

//pig implements the animal interface
class Pig: Animal{
    public void animalsound(){
        //the body of the animalsound is provided here
        Console.WriteLine("the pig says weee wee..");
    }
}
class Program{
    static void Main(string[] args){
        Pig p = new Pig();
        p.animalsound();
        Animal p1 = new Pig();
        p1.sleep();
    }
}
//C# handles default methods differently than Java to avoid the 
//"Diamond Problem" (where a class inherits two different versions
// of the same method from two different interfaces)
//By forcing you to upcast, C# knows exactly which interface's version of sleep() you want to use.