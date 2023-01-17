string name = "Ewa";
string maleSuffix = "-latek";
string femaleSuffix = "-latka";
bool woman = true;
var age = 33;


if (woman && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (name != "Ewa" && woman)
{
    Console.WriteLine(age + femaleSuffix + " o imieniu " + name);
}
else if (name != "Ewa" && !woman)
{
    Console.WriteLine(age + maleSuffix + " o imieniu " + name);
}
else if ( age < 18 && !woman)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine(" Pełnoletni Mężczyzna");
}




