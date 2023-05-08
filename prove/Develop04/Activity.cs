public class Activity{
    protected string _activityName;
    protected string _description;

    protected List<string> animationStrings = new List<string> {"/","-","|","\\"};
    
    public Activity (string activityName, string description){
        _activityName = activityName;
        _description = description;
    }

    public virtual void ExecuteActivity(int duration){
        //Use virtual to allow method overriding in child class
        //placeholder method to be overrided into child classes
    }

    public virtual void ExecuteActivity(int duration, int frequency){
        //Use virtual to allow method overriding in child class
        //placeholder method to be overrided into child classes
    }

    public virtual List<int> WelcomeMessage(){
        List<int> values = new List<int>();
        int duration = 0;

        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine($"\n{_description}");
        
        Console.Write("\nHow long in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        
        values.Add(duration);
        return values;
    }

    public void getReady(){
        Console.WriteLine("Get ready...");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

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