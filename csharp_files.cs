using System.IO; // include the System.IO namespace

string writetxt = "hello my name is sai, show them why ur better !"; //create a text string 
File.WriteAllText("file_gen_using_csharp.txt",writetxt);// Create a file and write the content of writeText to it

string readtxt = File.ReadAllText("file_gen_using_csharp.txt"); //read the contents of file
Console.WriteLine(readtxt);