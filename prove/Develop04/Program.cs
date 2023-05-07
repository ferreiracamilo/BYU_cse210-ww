using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflectionActivity = new ReflectionActivity("da","da");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        do{
            option = printMenu();
            if(option != 4){
                switch(option){
                    case 1:
                        breathingActivity.WelcomeMessage();
                        //esto
                        break;
                    case 2:
                        // reflectionActivity.WelcomeMessage();
                        //esto
                        break;
                    case 3:
                        listingActivity.WelcomeMessage();
                        //esto
                        break;
                }
            }
            Thread.Sleep(10);
        }while(option != 4);
        
    }

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