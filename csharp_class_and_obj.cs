class Car
{
    public string type = "SUV";   
}
class Student
{
    public string name = "sai"; //field
    public int roll_no = 25; //field
    public void profession() //method
    {
        Console.WriteLine("he is an SDE");
    }
}

class Employee_info
{
    public string name;
    public string department;
    public int age;
}
class Fruits
{
    String color = "red";
    static void Main(string[] args)
    {
        Fruits fr = new Fruits();
        Car c = new Car();
        Student s =  new Student(); 

        Console.WriteLine("Apple has " + fr.color + " color"); 
        Console.WriteLine("car is of type - " + c.type); 
        Console.WriteLine(s.name); 
        Console.WriteLine(s.roll_no); 
        s.profession(); 

        Employee_info e1 = new Employee_info();
        e1.name = "XYZ";
        e1.age = 21;
        e1.department = "HR";

        
        Employee_info e2 = new Employee_info();
        e2.name = "ABC";
        e2.age = 24;
        e2.department = "Consulting";

        Console.WriteLine(e1.name + " " + e1.age + " " + e1.department );
        Console.WriteLine(e2.name + " " + e2.age + " " + e2.department );
    }
}