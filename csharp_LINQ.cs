using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
// What is LINQ?
// LINQ means Language Integrated Query.
// It helps find, sort, and filter data.
// No long loops - just short, simple commands.
// Works with lists, databases, and more

// Lambda Expressions
// A shortcut to write tiny functions.
// Helps LINQ know what to look for.
// Example:                        
// means ‘Get the title!’
// is just a temporary name for each item

//example : 
//without LINQ :
/*
List<int> nums = new List<>(){1,2,3,4,5,6};
List<int> evens = new List<>();

foreach(int n in nums)
{
    if(n % 2 == 0)
    {
        evens.Add(n);
    }
}
*/

//with LINQ :
/*
var evens = nums.where(n => n % 2 == 0).ToList();
*/

//In all examples, we’re using this List of Game objects.


//1. required : In C#, the required keyword (introduced in C# 11) is 
// a tool for Data Integrity. It forces anyone creating an object to provide a value for 
// that property at the moment the object is created.
//e.g:
/*
class User {
    public required string Username { get; set; } 
}

// ERROR: You must initialize 'Username'
User myUser = new User(); 

// SUCCESS: This is the only way it works
User myUser = new User { Username = "Vishwajeet" };
*/

// 2. string? (The Nullable Reference Type)
// The ? is the most important part of this line.
// Without the ?: You are promising the compiler: "This variable will always have text. It will never be null." If you forget to give it a value, you get the warning CS8618 we saw earlier.
// With the ?: You are saying: "It is okay if this is null." This tells C# to stop worrying and stop giving you warnings about it being uninitialized.


// You can actually combine these: public required string? Genre { get; set; }.
// string? says: "The value can be null."
// required says: "You still have to explicitly tell me it's null when you create the object."

class Game
{
    public required string Title {get; set;}
    public string? Genre {get; set;}
    public int RealeaseYear {get; set;}
    public double Rating {get; set;}
    public int Price {get; set;}

}
class Program
{
    static void Main(string[] args)
    {
        var games = new List<Game>
    {
    new Game { Title = "The legends of zelda", Genre = "Adventure", RealeaseYear = 1986 , Rating = 9.5, Price = 60},
    new Game { Title = "Super Mario Bros.", Genre = "Platformer", RealeaseYear = 1985 , Rating = 9.2, Price = 50},
    new Game { Title = "Elden ring", Genre = "Adventure", RealeaseYear = 2022 , Rating = 9.8, Price = 50},
    new Game { Title = "Tetris", Genre = "Puzzle", RealeaseYear = 1984 , Rating = 8.9, Price = 10}
    };


    //for retriving all games 
    //traditional way
    foreach(var game in games)  
    {
        Console.WriteLine(game.Title);
    }

    //using linq
    var allgames = games.Select(g => g.Title);
    foreach (var title in allgames){
        {
            Console.WriteLine(title);
        }
    }

    // Rewrite the loop with the Select function to
    // make the code more concise and expressive.

    //filtering games by genre
    var AdventureGames = games.Where(g => g.Genre == "Adventure");
    foreach (var advgame in AdventureGames){
        Console.WriteLine(advgame);
    }

    //checking conditions
    var ismoderngameexist = games.Any(g => g.RealeaseYear > 2000);
    Console.WriteLine($"Are there modern games ?  {ismoderngameexist}");
    
    //The Any method checks if any element in the
    // collection matches the condition, returning a
    // boolean value. This is useful for quick
    // validations

    //sorting games
    var sortedByYear = games.OrderBy(g => g.RealeaseYear);
    foreach(var game in sortedByYear)
        {
            Console.WriteLine($"{game.Title} ({game.RealeaseYear})");
        }

    //Sort games by a property like release year using OrderBy

    //sorting in descending order
    var topRatedGames = games.OrderByDescending(g => g.Rating);
            foreach(var game in topRatedGames)
            {
                Console.WriteLine($"{game.Title} => Rating : {game.Rating}");
            }
    //To reverse the order, use OrderByDescending

    //aggregating data
    var averagePrice = games.Average(g => g.Price);
    Console.WriteLine($"average game price : {averagePrice}"); 

    var highestRating = games.Max(g => g.Rating);
    var bestgame = games.First(g => g.Rating == highestRating);
    Console.WriteLine($"highest Rated game: {bestgame.Title}__Rating: {bestgame.Rating}");

    //first and max gives the game with the highest rating by combining Max and First

    //Grouping by Genre
    var gamesByGenre = games.GroupBy(g => g.Genre);
    foreach(var group in gamesByGenre)
        {
            Console.WriteLine($"Genre: {group.Key}");
            foreach(var game in group)
            {
                Console.WriteLine($"{game.Title}");
            }
        }

    // Organize games by genre using GroupBy. This
    // method creates a collection of groups, each
    // containing elements that share a key.
}
}



