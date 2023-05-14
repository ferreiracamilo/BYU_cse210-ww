public class ChecklistGoal : Goal{

    // questionGoalName
    private readonly string _questionBonusQualificationGoalCount = "How many times does this goal need to be accomplished for a bonus?";
    private readonly string _questionBonusQualificationGoalRewardPoints = "What is the bonus for accomplising it that many times?";
    private int _bonusQualificationGoalCount;
    private int _bonusQualificationGoalRewardPoints;

    /// <summary>
    /// ChecklistGoal constructor that will require 3 arguments and completion count will be set as zero by default
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <returns>ChecklistGoal object</returns>
    public ChecklistGoal(string name, string description, int rewardPoints, int bonusQualificationGoalCount, int bonusQualificationGoalRewardPoints){
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _bonusQualificationGoalCount = bonusQualificationGoalCount;
        _bonusQualificationGoalRewardPoints = bonusQualificationGoalRewardPoints;
        _completionCount = 0;
    }

    public ChecklistGoal(){
        _name = "";
        _description = "";
        _rewardPoints = 0;
        _bonusQualificationGoalCount = 0;
        _bonusQualificationGoalRewardPoints = 0;
        _completionCount = 0;
    }

    public override void SaveGoal(){
        //asda
    }

    /// <summary>
    /// RecordEvent: will increase the completionCount quantity by one unit only if completionCount equals zero
    /// </summary>
    /// <exception cref="CompletionCountException">
    /// Thow generic exception when completionCount is not lower than _bonusTreshold
    /// </exception>
    public override void RecordEvent(){
        if(_completionCount < _bonusQualificationGoalCount){
            _completionCount++;
        }else{
            throw new CompletionCountException("Completion count must be lower or equal to bonus threshold, goal was achieved already.");
        }
    }

    public override int CalculatePoints(){
        int countPoints = 0;
        countPoints = _completionCount * _rewardPoints;
        
        if(_bonusQualificationGoalCount == _completionCount){
            countPoints += _bonusQualificationGoalRewardPoints;
        }

        return countPoints;
    }

    public override void AskInformation(){
        Console.WriteLine("\nChecklist Goal: It is a goal which requires a fixed amount of repetitions of a task/behavior and will provide a bonus by its total completion.\n");

        Console.Write($"{questionGoalName} ");
        _name = Console.ReadLine();
        
        Console.Write($"\n{questionGoalDescription} ");
        _description = Console.ReadLine();
        
        Console.Write($"\n{questionGoalPoints} ");
        _rewardPoints = int.Parse(Console.ReadLine());

        Console.Write($"\n{_questionBonusQualificationGoalCount} ");
        _description = Console.ReadLine();

        Console.Write($"\n{_questionBonusQualificationGoalRewardPoints} ");
        _description = Console.ReadLine();
    }
}