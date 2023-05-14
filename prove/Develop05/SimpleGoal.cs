public class SimpleGoal : Goal{

    /// <summary>
    /// SimpleGoal constructor that will require 3 arguments and completion count will be set as zero by default
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <returns>SimpleGoal object</returns>
    public SimpleGoal(string name, string description, int rewardPoints){
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _completionCount = 0;
    }

    public SimpleGoal(){
        _name = "";
        _description = "";
        _rewardPoints = 0;
        _completionCount = 0;
    }

    public override void SaveGoal(){
        //asda
    }

    /// <summary>
    /// RecordEvent: will increase the completionCount quantity by one unit only if completionCount equals zero
    /// </summary>
    /// <exception cref="CompletionCountException">
    /// Thow generic exception when completionCount is greather than zero
    /// </exception>
    public override void RecordEvent(){
        if(_completionCount == 0){
            _completionCount++;
        }else{
            throw new CompletionCountException("Completion count must be equal to zero.");
        }
    }

    public override int CalculatePoints(){
        return 1;
    }

    public static SimpleGoal askInformation(){
        return new SimpleGoal();
    }
}