public abstract class Goal{

    protected readonly string questionGoalName = "What is the name of your goal? ";
    protected readonly string questionGoalDescription = "What is a short description of it?";
    protected readonly string questionGoalPoitns = "What is the amount of points associated with this goal?";
    
    protected string _name;
    protected string _description;
    protected int _rewardPoints;
    protected int _completionCount;

    public abstract void SaveGoal();

    public abstract void RecordEvent();

    public abstract int CalculatePoints();

}