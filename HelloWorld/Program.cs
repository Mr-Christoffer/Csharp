// Console is an object
// that represents the terminal
// and has a method named WriteLine
// that we can call
// with a string as argument
// then string will then be written
// to the terminal
using System.ComponentModel;

Console.WriteLine("Hello, World!");
Console.WriteLine("ERROR!");

string name = "Ada";
int age = 36;
bool isDeveloper = false;

Console.WriteLine("Hur lång är du?");
string? heightAsString = Console.ReadLine();

if (!double.TryParse(heightAsString, out double height))
{
    height = 0.5;
    Console.WriteLine("Eftersom vi inte uppfattade din längd räknar vi med att du är 0.5 m lång");
}

Console.WriteLine(name + " är " + age + " år och " + height + " m lång.");
if (isDeveloper == true)
{
    Console.WriteLine(name + " är en utvecklare.");
}
else
{
    Console.WriteLine(name + " är inte en utvecklare.");
}
Console.WriteLine("Nedanstående är ett annat sätt att skriva ut samma sak som ovan, men med hjälp av en så kallad interpolerad sträng:");
Console.WriteLine($"{name} är {age} år och {height} m lång.");

if (isDeveloper)
{
    Console.WriteLine("Ada is a developer");
}
else
{
    Console.WriteLine("Ada is not a developer");
}


Console.WriteLine("Vad heter du?");
string? username = Console.ReadLine();
Console.WriteLine($"Du heter {username}");


Console.WriteLine($"Du heter {username} och är {height} meter lång");





