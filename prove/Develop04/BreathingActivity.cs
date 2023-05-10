public class BreathingActivity : Activity{

    public BreathingActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

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

    public override void ExecuteActivity(int duration, int frequency){
        getReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime){
            Console.WriteLine("\n");
            breath(frequency, true);

            Console.WriteLine("");
            breath(frequency, false);
        }

        completeMessage(duration);
    }

    private void breath(int frequency, Boolean isBreathIn){
        string breathInWording = "Breath in...";
        string breathOutWording = "Now breath out...";

        if(isBreathIn == true){
            Console.Write(breathInWording);
        }else{
            Console.Write(breathOutWording);
        }
        counterAnimation(frequency);
    }

}