public class Activity{
    protected string _activityName;
    protected string _description;

    public Activity (string activityName, string description){
        _activityName = activityName;
        _description = description;
    }

    public void ExecuteActivity(int duration){
        //placeholder method to be overrided into child classes
    }

    public void WelcomeMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long in seconds, would you like for your session?");
    }
}