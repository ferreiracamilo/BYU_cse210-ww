using System;

class Program
{
    static void Main(string[] args)
    {
        int response;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
            
            if(response != 0){
                //By implementing this throughout ZERO is needed to filter out ZERO before adding the number, otherwise will be added to the list
                numbers.Add(response);
            }
        }while(response != 0);

        Console.WriteLine($"The sum is: {numbers.Sum()}"); //CORE REQ 1
        Console.WriteLine($"The average is: {numbers.Average()}"); //CORE REQ 2
        Console.WriteLine($"The largest number is: {numbers.Max()}"); //CORE REQ 3
        Console.WriteLine($"The smallest positive number is: {numbers.Where(number => number > 0).Min()}"); //STRETCH 1 - Filter numbers list and then search the minimum
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers){
            Console.WriteLine(number);
        }
    }
}