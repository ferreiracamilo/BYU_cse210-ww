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
            //Breath in routine
            Console.WriteLine("\n");
            Console.Write($"Breath in...");
            for(int j=frequency;j>0;j--){
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            //Breath out routine
            Console.Write("\nNow breath out...");
            for(int k=frequency;k>0;k--){
                Console.Write(k);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

}