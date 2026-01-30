// In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

// Derived Class (child) - the class that inherits from another class
// Base Class (parent) - the class being inherited from
// To inherit from a class, use the : symbol.

// In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):

class Vehicle{
    public string brand = "Ford";
    public virtual void honk(){
        Console.WriteLine("Tuuu, Tutut !");
    }
}

class Car: Vehicle //derived class
{
    public string modelName = "Mustang";
    public override void honk(){
        Console.WriteLine("peeep pepepeppppeeeeeep");
    }
}

//class declared with sealed keyword cannot be inherited similiar to class declared with final keyword in java
sealed class Bike{

}
class Program{
    static void Main(string[] args){
        Vehicle obj = new Car();
        obj.honk();
        Console.WriteLine(obj.brand);
    }
}
//we have perform upcasting above to see overriden methods's o/p 
//virtual - Put this in the Parent class to say, "I allow children to change this."
//override - Put this in the Child class to say, "I am changing the parent's version."
//sealed - class cannot be inherited similiar to class declared with final in java