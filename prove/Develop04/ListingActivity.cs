public class ListingActivity : Activity{

    public ListingActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

}