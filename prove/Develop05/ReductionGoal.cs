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

    public override void AskInformation(){
        Console.WriteLine("\nReduction Goal: This goal is meant to specify behaviors/conducts/actions to avoid its repetition. Each time that is done will decreased the total points, this is measure over the time without contraints.\n");

        Console.Write($"{questionGoalName} ");
        _name = Console.ReadLine();
        
        Console.Write($"\n{questionGoalDescription} ");
        _description = Console.ReadLine();
        
        Console.Write($"\n{questionGoalPoints} ");
        _rewardPoints = int.Parse(Console.ReadLine());
    }
}