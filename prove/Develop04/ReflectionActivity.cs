public class ReflectionActivity : Activity{

    public ReflectionActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    public override void ExecuteActivity(int duration){
        getReady();
        
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