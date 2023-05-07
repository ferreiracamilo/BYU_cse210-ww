public class BreathingActivity : Activity{

    public BreathingActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    public override List<int> WelcomeMessage(){
        List<int> values = new List<int>();
        int duration;
        int pollingFrequency;
        
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine($"\n{_description}");

        Console.Write("\nHow long in seconds, would you like for your session?");
        duration = int.Parse(Console.ReadLine());
        Console.Write("\nHow long should take in seconds each round?");
        pollingFrequency = int.Parse(Console.ReadLine());
        
        values.Add(duration);
        values.Add(pollingFrequency);
        return values;
    }

    public override void ExecuteActivity(int duration){
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
    }

}