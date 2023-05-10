public class BreathingActivity : Activity{

    public BreathingActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    /// <summary>
    /// Print welcome message and collect values needed to be provided as arguments for executing activities
    /// </summary>
    /// <returns>List of int values(duration and/or frequency)</returns>
    public override List<int> WelcomeMessage(){
        List<int> values = new List<int>();
        int duration;
        int pollingFrequency;
        
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine($"\n{_description}");

        Console.Write("\nHow long in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.Write("\nHow long should take in seconds each round? ");
        pollingFrequency = int.Parse(Console.ReadLine());
        
        values.Add(duration);
        values.Add(pollingFrequency);
        return values;
    }

    /// <summary>
    /// Method will print in console indications to user to breath in and breath out during certain time and frequency rounds
    /// </summary>
    /// <param name="duration">Duration in seconds to perform this method</param>
    /// <param name="frequency">Duration of each breath round</param>
    public override void ExecuteActivity(int duration, int frequency){
        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime){
            Console.WriteLine("\n");
            breath(frequency, true);

            Console.WriteLine("");
            breath(frequency, false);
        }

        CompleteMessage(duration);
    }

    /// <summary>
    /// Print either breath in or breath out along a counter animation
    /// </summary>
    /// <param name="frequency">Duration of counter animation in seconds</param>
    /// <param name="isBreathIn">Boolean indicating is intended to breath in or breath out</param>
    private void breath(int frequency, Boolean isBreathIn){
        string breathInWording = "Breath in...";
        string breathOutWording = "Now breath out...";

        if(isBreathIn == true){
            Console.Write(breathInWording);
        }else{
            Console.Write(breathOutWording);
        }
        CounterAnimation(frequency);
    }

}