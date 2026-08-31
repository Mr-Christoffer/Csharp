// Console is an object
// that represents the terminal
// and has a method named WriteLine
// that we can call
// with a string as argument
// then string will then be written
// to the terminal
Console.WriteLine("Hello, World!");
Console.WriteLine("ERROR!");

string name = "Ada";
int age = 36;
double height = 1.72;
bool isDeveloper = true;

Console.WriteLine(name + " är " + age + " år och " + height + " m lång.");
if (isDeveloper == true)
{
    Console.WriteLine(name + " är en utvecklare.");
}
else
{
    Console.WriteLine(name + " är inte en utvecklare.");
}
Console.WriteLine($"{name} är {age} år och {height} m lång.");
Console.WriteLine({name} ör);
