public class ReflectionActivity : Activity{

    public ReflectionActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

}