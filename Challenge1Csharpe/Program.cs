// See https://aka.ms/new-console-template for more information

// Declare an empty string variable.
string userName;

Console.WriteLine("Please enter your name and press enter: ");
userName = Console.ReadLine();

Console.WriteLine(userName.ToUpper());
Console.WriteLine(userName.ToLower());
Console.WriteLine(userName.Trim());
Console.WriteLine(userName.Substring(1));
