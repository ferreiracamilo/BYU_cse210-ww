public class ChecklistGoal : Goal{

    private readonly string _questionBonusQualificationGoalCount = "How many times does this goal need to be accomplished for a bonus?";
    private readonly string _questionBonusQualificationGoalRewardPoints = "What is the bonus for accomplising it that many times?";
    private int _bonusQualificationGoalCount;
    private int _bonusQualificationGoalRewardPoints;

    /// <summary>
    /// ChecklistGoal constructor asking all parameters
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <param name="completionCount">Quantity of times that goal was accomplished</param>
    /// <param name="bonusQualificationGoalCount">Quantity of times that goal is required to be achieve to be eligible for bonus</param>
    /// <param name="bonusQualificationGoalRewardPoints">Quantity of points to grant for bonus achievement</param>
    /// <returns>ChecklistGoal object</returns>
    public ChecklistGoal(string name, string description, int rewardPoints, int completionCount, int bonusQualificationGoalCount, int bonusQualificationGoalRewardPoints){
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _completionCount = completionCount;
        _bonusQualificationGoalCount = bonusQualificationGoalCount;
        _bonusQualificationGoalRewardPoints = bonusQualificationGoalRewardPoints;
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
            Console.WriteLine($"Congratulations! You have earned {_rewardPoints} points!");
            if(_completionCount == _bonusQualificationGoalCount){
                Console.WriteLine($"Congratulations! You have earned the bonus reward, {_bonusQualificationGoalRewardPoints} points more!");
            }
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
        _bonusQualificationGoalCount = int.Parse(Console.ReadLine());

        Console.Write($"\n{_questionBonusQualificationGoalRewardPoints} ");
        _bonusQualificationGoalRewardPoints = int.Parse(Console.ReadLine());
    }

    public override string ToText(Boolean isShort){
        string objectFormatted = "";
        string statusBox = " ";

        if(_completionCount == 1){
            statusBox = "X";
        }

        if(isShort){
            objectFormatted=$"[{statusBox}] {_name} ({_description}) -- Currently completed: {_completionCount}/{_bonusQualificationGoalCount}";
        }else{
            objectFormatted=$"ChecklistGoal,{_name},{_description},{_rewardPoints},{_completionCount},{_bonusQualificationGoalCount},{_bonusQualificationGoalRewardPoints}";
        }

        return objectFormatted;
    }
}