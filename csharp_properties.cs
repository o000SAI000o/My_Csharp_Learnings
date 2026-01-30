//Encapsulation, is to make sure that "sensitive" data is hidden from users. 
//To achieve this, you must:
    //1. declare fields/variables as private
    //2. provide public get and set methods, through properties, to access and update the value of a private field 

class Person{
    private string name; // field
    public string Name //property
    { 
        get{ return name;}
        set{ name = value;}
    }
}
class Program 
{
    static void Main(string[] args)
    {
        Person obj = new Person();
        obj.Name = "sai";
        Console.WriteLine(obj.Name);
    }
}

// //short hand
// class Person2
// {
//     public string Name   //property
//     {get; set;}
// }

// class program2{
//     static void Main(string[] args){
//     Person2 p2 = new Person2();
//     p2.Name = "sai";
//     Console.WriteLine(p2.Name);
            
//     }
// }