using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int option = 0;
        Journal myJournal = new Journal();      
        do{
            Console.WriteLine("Please select one of the following choices");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            switch(option){
                case 1:
                    string myPrompt = Entry.RandomPrompt();
                    Console.Write($"\n{myPrompt} ");
                    string myReply = Console.ReadLine();
                    Entry myEntry = new Entry(myPrompt,myReply);
                    myJournal._entries.Add(myEntry);
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    myJournal.LoadJournal();
                    break;
                case 4:
                    myJournal.SaveJournal();
                    break;
                }
        }while(option != 5);
    }
}