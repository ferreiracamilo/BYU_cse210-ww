using System;

class Program
{
    static void Main(string[] args)
    {
        int docId = 44466454;
        string phoneNumber = "44-44";
        string address = "444 Jim St";
        string email = "camilo@mail.com";

        Console.WriteLine("The result of email validation is " + Utils.ValidateEmail(email));

        Vet vet1 = new Vet(docId, phoneNumber, address, email);

        Console.WriteLine();
        Console.WriteLine("Check below string representation return");
        Console.WriteLine(vet1.StringRepresentation());
    }
}