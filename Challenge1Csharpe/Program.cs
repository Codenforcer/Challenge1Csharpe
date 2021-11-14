// See https://aka.ms/new-console-template for more information

// Declare an empty string variable.
/*
string userName;

Console.WriteLine("Please enter your name and press enter: ");
userName = Console.ReadLine();
if (userName == null)
{
    Console.WriteLine("Please input a username");
}

Console.WriteLine(userName.ToUpper());
Console.WriteLine(userName.ToLower());
Console.WriteLine(userName.Trim());
Console.WriteLine(userName.Substring(1)); */


// Challenge 2. 

// Ask the user for a string.
Console.WriteLine("Enter a string here: ");
string userString = Console.ReadLine();


Console.WriteLine("Enter a character to search: ");
// Save user choosen Character to search.
char userChar = Console.ReadLine()[0];
// Find the index number  of the character from string.
int searchString = input.IndexOf(userChar);

Console.WriteLine("Index of character {0} in string is {1}", userChar, searchString);



