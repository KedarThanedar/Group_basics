// See https://aka.ms/new-console-template for more information
using Group_basics;

Console.WriteLine("Hello, World!");
Console.WriteLine(Maths.AddNumbers(2, 3));
GettersSetters getSetters = new GettersSetters();
getSetters.RunGetSetters();
IfElseSwitch.CheckIfElse(15,"First Number", 15,"Second Number");
Console.WriteLine(IfElseSwitch.CheckSwitch("microsoft"));
Loops.populateAndPrintArrayUsingWhile();
Loops.populateAndPrintArrayUsingFor();
Console.ReadLine();