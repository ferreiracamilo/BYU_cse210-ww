using System;

class Program
{
    static void Main(string[] args)
    {
        int docId = 44466454;
        string phoneNumber = "camilo4444";
        string address = "444 Jim St";
        string email = "camilo.www";

        Console.WriteLine("The result of phone validations is " + Utils.ValidatePhone(phoneNumber));
        Console.WriteLine("The result of email validation is " + Utils.ValidateEmail(email));

        DateOnly myDate = Utils.StringToDate("5/27/2023");
        Console.WriteLine(myDate);

        Vet vet1 = new Vet(docId, phoneNumber, address, email);

        Console.WriteLine();
        Console.WriteLine("Check below string representation return");
        Console.WriteLine(vet1.StringRepresentation());
    }
}