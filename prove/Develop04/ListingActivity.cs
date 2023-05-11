public class ListingActivity : Activity{

    private List<string> _prompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

    public ListingActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    /// <summary>
    /// Method will print in console a prompt expecting user to answer as many times possible within a given duration
    /// </summary>
    /// <param name="duration">Duration in seconds to perform this method</param>
    public override void ExecuteActivity(int duration){
        GetReady();

        Console.WriteLine("\nList as many responses you can to the following prompt");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        CounterAnimation(5);
        Console.WriteLine();

        int inputLineQty = WriteLinesForDuration(duration);

        Console.WriteLine($"You listed {inputLineQty} items");

        CompleteMessage(duration);
    }

    /// <summary>
    /// Get a random string value from class attribute 'prompts' list
    /// </summary>
    /// <returns>A string value from prompts list</returns>
    private string GetRandomPrompt(){
        Random random = new Random();
        int promptIndex  = random.Next(0, _prompts.Count-1);

        return _prompts[promptIndex];
    }

    /// <summary>
    /// This method will print each line with a number and > along a read console. Each time user completes an input will be counted.
    /// Method will executed the duration specified by argument
    /// </summary>
    /// <param name="duration">Duration in seconds to perform this method</param>
    /// <returns>Total count of input lines completed by user</returns>
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