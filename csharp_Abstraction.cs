//Abstract Classes and Methods
//Data abstraction is the process of hiding certain details and showing only essential 
//information to the user.Abstraction can be achieved with either abstract classes or 
//interfaces (which you will learn more about in the next chapter).
// The abstract keyword is used for classes and methods:
// Abstract class: is a restricted class that cannot be used to create objects 
//(to access it, it must be inherited from another class).
// Abstract method: can only be used in an abstract class, and it does not have a body. 
//The body is provided by the derived class (inherited from).

//abstract class
abstract class Animal{
    //abstract method (does not have a body)
    public abstract void animalsound();
    //regular method
    public void sleep(){
        Console.WriteLine("Zzzz..");
    }
}
//derived class inherits animal
class Pig: Animal{
    public override void animalsound(){
        Console.WriteLine("pig says : Oinkss...Oinkss");
    }
}

class Program{
    static void Main(string[] args){
        Pig p = new Pig(); //create a pig object
        p.animalsound(); //call the abstract methos
        p.sleep(); // call the regular method
    }
}