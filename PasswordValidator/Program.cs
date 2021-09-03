using System;

PasswordValidator1 validator = new PasswordValidator1();

while (true)
{
    Console.Write("Enter a password: ");
    string password = Console.ReadLine();

    if (validator.IsValid(password)) Console.WriteLine("That password is valid.");
    else Console.WriteLine("That password is not valid.");
}