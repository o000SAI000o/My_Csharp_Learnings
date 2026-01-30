class Car{
    public string model;
    public string color; 

    public Car()  // <-- default constructor
    {
        model = "SRT";
        color = "unknown";
    }
    public Car(string col){
        color = col;
        model = "Generic";
    }

    static void Main(string[] args)
    {
        Car c = new Car("Maroon");
        Console.WriteLine(c.model);
        Console.WriteLine(c.color);
    }
}