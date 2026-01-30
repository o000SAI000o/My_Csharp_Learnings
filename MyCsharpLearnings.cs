using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.IO.Pipelines;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using System.Timers;
using System.Xml; //its used to import system namespace so tht we can built-in .NET classes similiar to import java.util.*; in java
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System.Xml.Schema;
using System.Net.NetworkInformation;

//csharp is case sensitive myclass and MyClass has different meanings
public class MyCsharpLearnings
{

    

        //Method
        //A method is a block of code which only runs when it is called.
        //You can pass data, known as parameters, into a method.
        //Methods are used to perform certain actions, and they are also known as functions.
        //Why use methods? To reuse code: define the code once, and use it many times.
        //A method is defined with the name of the method, followed by parentheses (). C# provides 
        // some pre-defined methods, which you already are familiar with, such as Main(), but you can also create your own methods to perform certain actions:

        static void mymethod()
    {
        Console.WriteLine("mymethod got executed !");
    } 

        static void isAnimal(String aname)
    {
        Console.WriteLine(aname + "is an animal for sure !.");
    }

        static int GCD(int num101, int num102)
    {   
        if(num101 == 0)return num102;
        return GCD(num102 % num101, num101);
    }
        static void greet(String guestname = "guest")
    {
        Console.WriteLine("Welcome !" + guestname);
    }
        static void avengers(String firstfav, String secondfav, String thirdfav)
    {
        Console.WriteLine("my first fav avenger is : " + firstfav + " " + "my second fav avenger is: " + secondfav + " " + "my third fav avenger is : " + thirdfav );
    }
    
        static int square(int number)
    {
        return number*number;
    }
        static float square(float numbr)
    {
        return numbr*numbr;
    }

    // MyMethod() is the name of the method
    // static means that the method belongs to the Program class and not an object of the Program class. You will learn more about 
    // objects and how to access methods through objects later in this tutorial.
    // void means that this method does not have a return value. You will learn more about return values later in this chapter
    static void Main(string[] args)
    {
        Console.WriteLine("Hello sai"); // to o/p the data
        //console is a class of System namespace which has WriteLine() method
        //if you omit the using System line, you would have to write System.Console.WriteLine() to print/output text. 
        //every statement ends with semicolon
        //WriteLine() print data on newline each time similiar System.out.println()
        Console.WriteLine("I am learning c#");
        Console.WriteLine(3+3);
        Console.Write("this is a sum");
        Console.Write(10+10); // this will be printed on a same line 
        //Write is similiar to WriteLine() only diff is it doesnt add newlinw at the end similiar to System.out.print()
        // this is single line comment using '//'same as java
        /*multiline comment is also same as java  */ 
        

        //csharp variables
        int a = 10;
        double b = 10.00;
        char ch = 's';
        string str = "hello world";
        bool z = true;
        Console.WriteLine(a + " "+ b + " "+ ch + " " + str + " " + z);
        //we add const keyword in front of var to avoid overwriting of the existing values
        const string strr = "this is e.g of constant";
        //we can also perform string concatenation using the + operator
        string s1 = "my",s2 = "name",s3 = "sai";
        Console.WriteLine(s1+s2+s3);
        //we can also assign same value to multiple variables in one line
        int x,y,w;
        x = y = w = 10;
        Console.WriteLine(x+y+w);


        // All C# variables must be identified with unique names.
        // These unique names are called identifiers.
        // Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).
        // Good
        int minutesPerHour = 60;

        // OK, but not so easy to understand what m actually is
        int m = 60;
        /*
        The general rules for naming variables are:
            Names can contain letters, digits and the underscore character (_)
            Names must begin with a letter or underscore
            Names should start with a lowercase letter, and cannot contain whitespace
            Names are case-sensitive ("myVar" and "myvar" are different variables)
            Reserved words (like C# keywords, such as int or double) cannot be used as names
        */

        long l = 12000L;
        double d = 1290839D;
        float f = 5.75F;
        Console.WriteLine(l);
        Console.WriteLine(d);
        Console.WriteLine(f);


        //type casting in csharp

        //Implicit Casting (automatically) - converting a smaller type to a larger type size
        //char -> int -> long -> float -> double
        int myint = 10;
        float mydoubleint = myint;
        Console.WriteLine(mydoubleint);

        //Explicit Casting (manually) - converting a larger type to a smaller size type
        //double -> float -> long -> int -> char
        double mydouble = 9.78;
        int myint1 = (int) mydouble;
        Console.WriteLine(myint1);

        //type conversion methods
        int aa = 12;
        double dd = 12.12;
        bool bb = true;
        Console.WriteLine(Convert.ToString(bb));
        Console.WriteLine(Convert.ToDouble(aa));
        Console.WriteLine(Convert.ToInt32(dd));
        Console.WriteLine(Convert.ToString(bb));

        //user input
        Console.WriteLine("Enter ur name this is a user input");
        string name = Console.ReadLine();

        //Console.ReadLine() is used to take user input of String datatype
        if(name == "sai")
        {
            Console.WriteLine("welcome admin");
        }
        else
        {
            Console.WriteLine("Not a admin");
        }

        //as Console.ReadLine() takes input of string type only we can use Convert methods to take user input of desired 
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age > 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Not Adult");
        }

        //operator
        Console.WriteLine(12+12);
        Console.WriteLine(12-12);
        Console.WriteLine(12*12);
        Console.WriteLine(12/12);
        Console.WriteLine(12%2);
        int num = 12;
        num++;
        Console.WriteLine(num);
        num--;
        Console.WriteLine(num);


        //assignment ops
        //  =	x = 5	x = 5	
        // +=	x += 3	x = x + 3	
        // -=	x -= 3	x = x - 3	
        // *=	x *= 3	x = x * 3	
        // /=	x /= 3	x = x / 3	
        // %=	x %= 3	x = x % 3	
        // &=	x &= 3	x = x & 3	
        // |=	x |= 3	x = x | 3	
        // ^=	x ^= 3	x = x ^ 3	
        // >>=	x >>= 3	x = x >> 3	
        // <<=	x <<= 3	x = x << 3

        //comparison ops
        //Operator	Name	                Example	Try it
        // ==	    Equal to	                x == y	
        // !=	    Not equal	                x != y	
        // >	    Greater than	            x > y	
        // <	    Less than	                x < y	
        // >=	    Greater than or equal to	x >= y	
        // <=	    Less than or equal to	    x <= y

        //logical ops
        //&& 	Logical and	    Returns True if both statements are true	x < 5 &&  x < 10	
        //|| 	Logical or	    Returns True if one of the statements is true	x < 5 || x < 4	
        //!	    Logical not	    Reverse the result, returns False if the result is true	!(x < 5 && x < 10)

        Console.WriteLine(Math.Max(5,10));
        Console.WriteLine(Math.Min(5,10));
        Console.WriteLine(Math.Sqrt(25));
        Console.WriteLine(Math.Abs(-25));
        Console.WriteLine(Math.Round(9.99));
    

    //String
    //A string variable can contain many words, if you want:
    String strrr = "Nice to meet u";
    Console.WriteLine("The length of string is " + strrr.Length);
    Console.WriteLine(strrr.ToUpper());
    //string concatenation
    Console.WriteLine(strrr+str);
    Console.WriteLine(string.Concat(strrr+str));
    //string interpolation, which substitutes values of variables into placeholders in a string.
    //Note that you do not have to worry about spaces, like with concatenation:
    //its similiar to formated print
    string fname = "sai";
    string lname = "deshmane";
    Console.WriteLine($"my name is {fname} {lname}");

    //access strings
    Console.WriteLine(fname[0]);
    Console.WriteLine(fname.IndexOf("i"));
    Console.WriteLine(fname.IndexOf("i"));
    Console.WriteLine(fname.Substring(fname.IndexOf("i")));


    //String speacial characters
    // \'  -  for single quote
    // \"  -  for double quote
    // \\  -  for backslash 
    String txt = "we are the so called \"Vikings\" from the earth";
    Console.WriteLine(txt);
    
    bool isCSharpFun = true;
    bool isFishTasty = false;
    Console.WriteLine(isCSharpFun);   // Outputs True
    Console.WriteLine(isFishTasty);   // Outputs False
    
    int xx = 10;
    int yx = 9;
    Console.WriteLine(xx > yx); // returns True, because 10 is higher than 9

    //if..elseif and else
    Console.WriteLine("Enter ur age");
    int agee = Convert.ToInt32(Console.ReadLine());
    if (agee > 18)
        {
            Console.WriteLine("eligible for voting");
        }
    else if(agee < 18){
        Console.WriteLine("Not eligible for voting");
        }
    else
        {
        Console.WriteLine("ur 18 and eligible too");       
        }


    //ternary if else
    Console.WriteLine("Enter time");
    int time = Convert.ToInt32(Console.ReadLine());
    String result = (time > 18) ? "Good evening": "good day";
    Console.WriteLine(result);

    //switch w
    Console.WriteLine("Enter ur choice :\n 1.Cricket \n2.Football \n3.ice_hockey \n4.None");
    int opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
        {
            case 1:
                Console.WriteLine("i love cricket");
                break;
            case 2:
                Console.WriteLine("i love football");
                break;
            case 3:
                Console.WriteLine("i love ice hockey");
                break;
            case 4:
                Console.WriteLine("None");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

    //In C#, the var keyword is used for implicitly typed local variables, where the compiler automatically 
    // determines the variable's precise, static type based on the value assigned to it at compile time. 
    //It is not a data type itself, nor does it make the variable dynamically typed; it is simply a syntactical 
    // convenience to reduce code redundancy. 
    var xu = 12;
    Console.WriteLine(xu);

//     Java introduced the var keyword in Java 10 (released in 2018) for local variable type inference. 
// It works very similarly to C#, but with a few distinct rules:
// Usage Scope: Just like in C#, Java's var is only for local variables inside methods, constructors, or 
//initialisation blocks. It cannot be used for class fields, method parameters, or return types.
// Initialization: You must provide an immediate initializer so the compiler can infer the type. You cannot initialize 
//it to null because null does not have a specific type.
// Keyword vs. Reserved Type Name: Technically, in Java, var is a reserved type name, not a reserved keyword. 
//This means you can still use var as a variable or method name (e.g., int var = 5;), though it is strongly discouraged.
// Lambda Support: Since Java 11, you can use var in lambda parameters to apply annotations (like @Nonnull) while still using type 

    //while loop
    var i = 5;
    while(i > 0)
        {
            int current = i;
            i--;
            if(current % 2 == 0) continue;
            Console.WriteLine(current);
        }

        var j = 10;
        //do while
        do
        {
            Console.WriteLine(j);
            j++;
        }while(j < 10);


        //for loop
        for(int n=0; n<5; n++)
        {
            Console.WriteLine(n);
        }


        //nested loop
        for(int g=1; g<5; g++)
        {
            for(int h=1; h<=g; h++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        //foreach loop -  which is used exclusively to loop through elements in an array (or other data sets)
        string[] cars = {"BMW","Mclaren","buggati"};
        foreach(string car in cars)
        {
            Console.WriteLine(car);
        }


        //arrays in c# similiar to java

        string[] caars = {"Volvo", "BMW", "Ford", "Mazda"};
        //if we want to change ele in array
        caars[0] = "Opel";
        Console.WriteLine(caars[0]);

        //for both string as well as array Length keyword is used to find out the length array or string
        Console.WriteLine(caars.Length);

        //other ways of creating arrays
        // Create an array of four elements, and add values later
        string[] carss = new string[4];

        // Create an array of four elements and add values right away 
        string[] carsss = new string[4]{"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements without specifying the size 
        string[] carrss = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] ccars = {"Volvo", "BMW", "Ford", "Mazda"};

        // Declare an array
        string[] ccaars;

        // Add values, using new
        ccaars = new string[] {"Volvo", "BMW", "Ford"};

        // loop over an array
        String[] carssss = {"Volvo", "BMWwwwwww", "Ford", "Mazda"};
        foreach(String s in carssss)
        {
            Console.WriteLine(s);
            
        }

        //using idx
        for(int idx=0; idx<carssss.Length; idx++)
        {
            Console.WriteLine(carssss[idx]);
        }

        //sorting arrays - using Sort() method
        carssss.Sort();
        foreach(String c in carssss)
        {
            Console.WriteLine(c);
        }

        //System.Linq Namespace
        // useful array methods such as Min, Max, Sum can be found in System.Linq added at top of this code
        int[] nu = {1,5,2,7,1,6};
        Console.WriteLine(nu.Min());
        Console.WriteLine(carssss.Max());
        //above gives car naeme having highest ascii value as comapre to othere tht is Volvo,also lowercase asciii sum > tht of uppercase 
        Console.WriteLine(carssss.Max(cr => cr.Length));
        //above gives tht string or car having highest length
        Console.WriteLine(nu.Min());
        Console.WriteLine(nu.Sum());

        //to create 2d arrays we use same way as we use in java and insert , inside square bracket -> [,]
        //A three-dimensional array would have two commas: int[,,].
        int[,] numbs = {{1,2,3},{4,5,6}};
        //access ele of 2d array
        Console.WriteLine(numbs[0,2]); //ele at oth row and 2nd col
        //inorder to change value
        numbs[0,2] = 9;

        //loop through nested arrays
        //can use nested foreach for loopNo, not with a 2D array (int[,]).
        //Because a 2D array is a single block of memory, C# doesn't see "rows" as separate objects you can loop through.

        //other approach
        // Use GetLength(0) for Rows and GetLength(1) for Columns
        for(int r = 0; r < numbs.GetLength(0); r++)
        {
            for(int c = 0; c < numbs.GetLength(1); c++)
            {
                Console.Write(numbs[r,c] + " ");
            }
            Console.WriteLine();// New line after each row
        }
        //numbs.GetLength(0): Returns the number of rows (in this case, 2).
        //numbs.GetLength(1): Returns the number of columns (in this case, 3).

        //method call
        //see above
        mymethod();

        //method with arg
        //see above
        isAnimal("rabbit "); // arg
        isAnimal("panther ");   // arg
        isAnimal("cheetah ");   //arg
        //When a parameter is passed to the method, it is called an argument. So, 
        // from the example above: aname is a parameter, while rabbit, panther and cheetah are arguments.

        //method with multiple args
        //see above
        int resul = GCD(12,16);
        Console.WriteLine(resul);

        //method with default parameter
        //see above
        greet();
        
        //named arguments - It is also possible to send arguments with the key: value syntax.
        //That way, the order of the arguments does not matter
        avengers(firstfav:"Steve Rogers",secondfav:"Spiderman",thirdfav:"Dr.Strange");

        //Method Overloading
        int k = square(100); //takes int arg
        Console.WriteLine(k); // takes float arg
        float u = square(6.25f); // takes float arg
        Console.WriteLine(u); // takes float arg
        // 10.5f => float (32-bit, less precise)
        // 10.5 => double (64-bit, standard for math)
        // 10.5m => decimal (128-bit, used for money/finance)

}   
}