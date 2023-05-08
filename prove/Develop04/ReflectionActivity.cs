public class ReflectionActivity : Activity{

    private List<string> prompts = new List<string> {"Think of a time when you did something really difficult","Think of a time when you treat badly a relative","Think if you could've done any better during your day","Think of a time when you feel sad and how could you faced this in the present"};
    private List<string> questions = new List<string> {"What is your favorite thing about this experience?","How did you feel when it was completed?","Would you like to be asked about something else?","Did you reflect and learn with this experience?"};
    public ReflectionActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    public override void ExecuteActivity(int duration){
        getReady();

        Random rnd1 = new Random();
        int promptIndex  = rnd1.Next(0, 4);

        Console.WriteLine("\nConsider the following prompt");
        Console.WriteLine($"\n--- {prompts[promptIndex]} ---");

        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        ConsoleKeyInfo c = Console.ReadKey();
        if(c.Key == ConsoleKey.Enter){
            Console.WriteLine("\n\nNow ponder each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            for(int k=5;k>0;k--){
                Console.Write(k);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }else{
            throw new Exception("You pressed a different key, execute application again and do not forget to follow indications.");
        }

        // ## CONSIDER THE ACTUAL DURATION SELECTED BY USER ##
        Random rnd2 = new Random();
        int promptQuestion  = rnd1.Next(0, 4);

        Console.Clear();
        Console.WriteLine(questions[promptQuestion]);
        
        int i = 0;
        DateTime startTime1 = DateTime.Now;
        while(startTime1 < startTime1.AddSeconds(duration/2)){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");            

            i++;

            if(i >= animationStrings.Count){
                i = 0;
            }
        }
        promptQuestion  = rnd1.Next(0, 4);
        Console.WriteLine(questions[promptQuestion]);
        i = 0;

        DateTime startTime2 = DateTime.Now;
        while(startTime2 < startTime2.AddSeconds(duration/2)){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");            

            i++;

            if(i >= animationStrings.Count){
                i = 0;
            }
        }

        Console.WriteLine("\nWell done!!");
        
        Console.WriteLine($"You have completed another {duration} second/s of the Reflecting Activity");

        /*
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while(DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= animationStrings.Count){
                i = 0;
            }
        }
        */
    }
}