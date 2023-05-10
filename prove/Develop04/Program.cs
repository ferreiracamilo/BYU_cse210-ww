using System;

class Program
{
    static void Main(string[] args)
    {   
        int option = 0;
        List<int> parameters = new List<int>();

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        do{
            option = printMenu();
            if(option != 4){
                switch(option){
                    case 1:
                        Console.Clear();
                        parameters = breathingActivity.WelcomeMessage();
                        Console.Clear();
                        breathingActivity.ExecuteActivity(parameters[0],parameters[1]);
                        break;
                    case 2:
                        Console.Clear();
                        parameters = reflectionActivity.WelcomeMessage();
                        Console.Clear();
                        reflectionActivity.ExecuteActivity(parameters[0]);
                        break;
                    case 3:
                        Console.Clear();
                        parameters = listingActivity.WelcomeMessage();
                        Console.Clear();
                        listingActivity.ExecuteActivity(parameters[0]);
                        break;
                }
            }
            Thread.Sleep(10);
        }while(option != 4);
    }

    /// <summary>
    /// Print menu method to reduce code lines within the case block and provide user possibility to indicate which option to be selected
    /// </summary>
    /// <returns>int number representing option selected</returns>
    public static int printMenu(){
        int option;
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());
        return option;
    }
}