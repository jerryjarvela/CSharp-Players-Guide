using System;


//• Make a program with 5 Console.WriteLine statements in it.
//• Answer this question: How many statements do you think a program can contain?
// Reward: + 50XP
Console.WriteLine("Ritlin, this is my power.");
Console.WriteLine("I do not know how to use it yet..");
Console.WriteLine("But I will do my best to help the world.");
Console.WriteLine("Yeah, I ran out of roleplay power.");
Console.WriteLine("+ 50 XP earned from challenge!");
Console.WriteLine("\n");


//• Make a program that runs as shown above, including taking a name from the user
string userInputName;
Console.WriteLine("Telims bread is ready for transaction.");
Console.Write("Who is the bread for? Please sign the transaction here: ");
userInputName = Console.ReadLine();
Console.WriteLine("The transaction was signed by " + userInputName + " and received their bread.");
Console.WriteLine("\n");


//• Rebuild the program above on your computer.
//• Add comments near each of the four variables that describe what they store. You must use at least 
//one of each comment type (// and /* */).
//• Find the bug in the text displayed and fix it.
//• Answer this question: Aside from comments, what is one other thing you could do to make this 
//code more understandable.
//ANSWER: make variables and method names descriptive.

Console.WriteLine("What kind of thing are we talking about?");

// The thing input
string a = Console.ReadLine();


Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Adjective of said thing
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + a + " " + b + " of " + c + " " + d + "!");