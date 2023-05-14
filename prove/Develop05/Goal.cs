public abstract class Goal{

    protected readonly string questionGoalName = "What is the name of your goal? ";
    protected readonly string questionGoalDescription = "What is a short description of it?";
    protected readonly string questionGoalPoints = "What is the amount of points associated with this goal?";
    
    protected string _name;
    protected string _description;
    protected int _rewardPoints;
    protected int _completionCount;

    public abstract void SaveGoal();

    /// <summary>
    /// RecordEvent will increase the completionCount quantity by one unit
    /// </summary>
    public virtual void RecordEvent(){
        _completionCount++;
    }

    /// <summary>
    /// CalculatePoints: It will calculate points obtained either based on completion count and/or bonus obtained if applies
    /// </summary>
    /// <returns>An int representing points obtained from goal</returns>
    public virtual int CalculatePoints(){
        return _completionCount * _rewardPoints;
    }

    /// <summary>
    /// AskInformation: It will print the messages to ask required information and update a dummy object created previously
    /// </summary>
    public abstract void AskInformation();

}