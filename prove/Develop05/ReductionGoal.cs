public class ReductionGoal : Goal{

    /// <summary>
    /// ReductionGoal constructor that will require 3 arguments and completion count will be set as zero by default
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <returns>ReductionGoal object</returns>
    public ReductionGoal(string name, string description, int rewardPoints){
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _completionCount = 0;
    }

    public ReductionGoal(){
        _name = "";
        _description = "";
        _rewardPoints = 0;
        _completionCount = 0;
    }

    public override void SaveGoal(){
        //asda
    }

    public override int CalculatePoints(){
        return (_completionCount * _rewardPoints) * -1;
    }

    public override Goal AskInformation(){
        return new SimpleGoal();
    }
}