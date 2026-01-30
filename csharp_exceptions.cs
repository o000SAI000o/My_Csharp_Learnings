// The try statement allows you to define a block of code to be 
//tested for errors while it is being executed.
// The catch statement allows you to define a block of code 
//to be executed, if an error occurs in the try block.
// The try and catch keywords come in pair

try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);  //instead of e.Message we can pass custom message
}
finally{
    Console.WriteLine("The try catch has been finished");
}
Console.WriteLine("Enter age - ");
int age = Convert.ToInt32(Console.ReadLine());
if(age > 18){
    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
}
else
{
 Console.WriteLine("Access granted - You are old enough!");
}