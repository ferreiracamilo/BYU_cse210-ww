public class ReductionGoal : Goal{

    /// <summary>
    /// ReductionGoal constructor asking all parameters
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <param name="completionCount">Quantity of times that goal was accomplished</param>
    /// <returns>ReductionGoal object</returns>
    public ReductionGoal(string name, string description, int rewardPoints, int completionCount){
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _completionCount = completionCount;
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

    public override void RecordEvent(){
        _completionCount++;
        Console.WriteLine($"Bad Luck! You have lost {_rewardPoints} points!");
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

    public override string ToText(Boolean isShort){
        string objectFormatted = "";

        if(isShort){
            objectFormatted=$"[ ] {_name} ({_description})";
        }else{
            objectFormatted=$"ReductionGoal,{_name},{_description},{_rewardPoints},{_completionCount}";
        }

        return objectFormatted;
    }
}