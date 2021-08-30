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
Console.WriteLine("The " + a + " " + b +  c + " " + d + "!");

Console.WriteLine("hello world");

int integer = 1;
short short1 = 2; 
long long1 = 3;
byte byte1 = 4;
sbyte sbyte1 = 5;
uint uint1 = 6;
ushort ushort1 = 7;
ulong ulong1 = 8;
char char1 = 'A';
string message = "hello world!";
float float1 = 1.234F;
double double1 = 1.234;
decimal decimal1 = 1.0m;
bool isBool = true;

Console.WriteLine(integer);
Console.WriteLine(short1);
Console.WriteLine(long1);
Console.WriteLine(byte1);
Console.WriteLine(sbyte1);
Console.WriteLine(uint1);
Console.WriteLine(ushort1);
Console.WriteLine(ulong1);
Console.WriteLine(char1);
Console.WriteLine(message);
Console.WriteLine(float1);
Console.WriteLine(double1);
Console.WriteLine(decimal1);
Console.WriteLine(isBool);

integer = 0;
short1 = 1;
long1 = 2;
byte1 = 3;
sbyte1 = 4;
uint1 = 5;
ushort1 = 6;
ulong1 = 7;
char1 = 'B';
message = "Henlo goob";
float1 = -1.1234F;
double1 = -1.1234;
decimal1 = -1.1234m;
isBool = false;

Console.WriteLine(integer);
Console.WriteLine(short1);
Console.WriteLine(long1);
Console.WriteLine(byte1);
Console.WriteLine(sbyte1);
Console.WriteLine(uint1);
Console.WriteLine(ushort1);
Console.WriteLine(ulong1);
Console.WriteLine(char1);
Console.WriteLine(message);
Console.WriteLine(float1);
Console.WriteLine(double1);
Console.WriteLine(decimal1);
Console.WriteLine(isBool);

int area;
Console.WriteLine("Please input triangle size: ");
string baseSize = Console.ReadLine();
Console.WriteLine("Please input triangle size: ");
string baseHeight = Console.ReadLine();

area = (int.Parse(baseSize) * int.Parse(baseHeight)) / 2;

Console.WriteLine("The triangle area is: " + area);

Console.WriteLine("Please enter the number of daily chocolate eggs: ");
string eggs = Console.ReadLine();
int parse = (int.Parse(eggs) / 4) % 4;
Console.WriteLine("Number of chocolate eggs remainder: ");
Console.Write(parse);