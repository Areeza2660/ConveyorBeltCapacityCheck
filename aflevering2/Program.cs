
Console.WriteLine("Hello, World!");
Console.WriteLine("How many motors are carrying the packages?");
var antalmotor= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many kg of packages do we expect?");
var antalkg = Convert.ToDouble(Console.ReadLine());

if(antalkg/antalmotor>=5.6) 
    Console.WriteLine("Yes");
else
{
    Console.WriteLine("No");
}

