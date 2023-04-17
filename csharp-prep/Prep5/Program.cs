using System;

class Program
{
    static void Main(string[] args){
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        DisplayResult(name, SquareNumber(favNum));
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int SquareNumber(int number){
        int sqrNum = number * number; // Math.Sqrt(81) however this one requires DOUBLE type, on this case we are using int so makes no sense besides is only square
        return sqrNum;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int favnumber = int.Parse(Console.ReadLine());
        return favnumber;
    }

    static void DisplayResult(String name, int squareNumber){
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}