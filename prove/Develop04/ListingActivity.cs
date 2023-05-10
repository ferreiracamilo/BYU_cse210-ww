public class ListingActivity : Activity{

    private List<string> prompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

    public ListingActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    public override void ExecuteActivity(int duration){
        getReady();

        Console.WriteLine("\nList as many responses you can to the following prompt");
        Console.WriteLine($"--- {getRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        counterAnimation(5);
        Console.WriteLine();

        int inputLineQty = WriteLinesForDuration(duration);

        Console.WriteLine($"You listed {inputLineQty} items");

        completeMessage(duration);
    }

    private string getRandomPrompt(){
        Random random = new Random();
        int promptIndex  = random.Next(0, prompts.Count-1);

        return prompts[promptIndex];
    }

    private int WriteLinesForDuration(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        string line;
        List<string> inputLines = new List<string>();
        int lineCounter = 1;

        while(DateTime.Now < endTime){
            Console.Write($"{lineCounter} > ");
            line = Console.ReadLine();
            inputLines.Add(line);
            lineCounter++;
        }

        return inputLines.Count();
    }

}