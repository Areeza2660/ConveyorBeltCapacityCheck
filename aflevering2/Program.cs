Console.WriteLine("Hello, User!");
Console.WriteLine("How many motors are carrying the packages?");

var input = Console.ReadLine();
var motors = int.Parse(input);

Console.WriteLine("How many kg of packages do we expect?");
double kg = Convert.ToDouble(Console.ReadLine());

if (kg / motors <= 5.6)
    Console.WriteLine("Yes, possible");
else
    Console.WriteLine("No, not possible");
