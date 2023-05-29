using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("The result of email validation is " + Utils.ValidateEmail(email));
        string name = "Juancho";
        DateOnly birthDate = new DateOnly(2010, 1, 1);
        string animalType = "Dog";
        string breed = "Terbal";
        int id = 1;

        Pet pet1 = new Pet(name, birthDate, animalType, breed, id);

        Console.WriteLine();
        Console.WriteLine("This is string representation with allergies");
        string one = pet1.StringRepresentation();
        Console.WriteLine(pet1.StringRepresentation());
    }
}