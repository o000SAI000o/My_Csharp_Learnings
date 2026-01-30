// Multiple Interfaces
// To implement multiple interfaces, separate them with a comma

interface Firstinterface{
    void firstmethod();
}

interface Secondinterface{
    void secondmethod();
}

class Democlass : Firstinterface, Secondinterface{
    public void firstmethod(){
        Console.WriteLine("This is a first method");
    }

    public void secondmethod(){
        Console.WriteLine("This is a second method");
    }
}

class Program{
    static void Main(string[] args){
        Democlass obj = new Democlass();
        obj.firstmethod();
        obj.secondmethod();
    }
}