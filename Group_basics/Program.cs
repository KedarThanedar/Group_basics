// See https://aka.ms/new-console-template for more information
using Group_basics;

Console.WriteLine("Hello, World!");
Console.WriteLine(Maths.AddNumbers(2, 3));
Console.WriteLine(Maths.SubNumbers(20, 4));
Console.WriteLine(Maths.MulNumbers(2, 3));
Console.WriteLine(Maths.DivNumbers(20, 3));
Console.WriteLine(Maths.Reminder(20, 3));
GettersSetters getSetters = new GettersSetters();
getSetters.RunGetSetters();
IfElseSwitch.CheckIfElse(15, "First Number", 15, "Second Number");
Console.WriteLine(IfElseSwitch.CheckSwitch("microsoft"));
Loops.populateAndPrintArrayUsingWhile();
Loops.populateAndPrintArrayUsingFor();
Console.ReadLine();