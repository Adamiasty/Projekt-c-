

var name = "Ewa";
var sex = "kobieta";
var age = 30;

if (sex == "kobieta" && age < 30) 
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
else if (name == "Ewa" && age == 30 && sex == "kobieta")
    {
        Console.WriteLine("Ewa, lat 30");
    }
else if (sex != "kobieta" && age < 30)
    {
    Console.WriteLine("Niepełnoletni mężczyzna");
    }