
//using static System.Console;
//using static Methods.SampleMethods;
using Methods;

// DRY - Don't Repeat Yourself
// SOLID - S: SRP - Single Responsibility Principle

//string name = SampleMethods.GetUsersName();

//SampleMethods.SayHi(name);
Console.WriteLine("DRY\nSOLID");
SampleMethods.SayGoodbye();

double result = MathShortcuts.Add(3, 5);
Console.WriteLine($"The result is {result}.");

double[] vals = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
Console.WriteLine($"The total is {MathShortcuts.AddAll(vals)}.");

// Discard Character (_)
(string firstName, _) = SampleMethods.GetFullName();
Console.WriteLine($"First name: {firstName}");
//Console.WriteLine$"Last Name: {fullName.lastName}");
