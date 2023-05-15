public class SimpleGoal : Goal{

    /// <summary>
    /// SimpleGoal constructor asking all parameters
    /// </summary>
    /// <param name="name">Name to assign to new Simple Goal object</param>
    /// <param name="description">Short description to assign to new Simple Goal object</param>
    /// <param name="rewardPoints">Quantity of reward points to provide if Simple Goal object is accomplished</param>
    /// <param name="completionCount">Quantity of times that goal was accomplished</param>
    /// <returns>SimpleGoal object</returns>
    public SimpleGoal(string name, string description, int rewardPoints, int completionCount){
        _name = name;
        _description = description;
        _rewardPoints = rewardPoints;
        _completionCount = completionCount;
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
            Console.WriteLine($"Congratulations! You have earned {_rewardPoints} points!");
        }else{
            throw new CompletionCountException("Completion count must be equal to zero, goal was achieved already.");
        }
    }

    public override void AskInformation(){
        Console.WriteLine("\nSimple Goal: It is a goal which is intended to be completed in one attempt or cycle.\n");

        Console.Write($"{questionGoalName} ");
        _name = Console.ReadLine();
        
        Console.Write($"\n{questionGoalDescription} ");
        _description = Console.ReadLine();
        
        Console.Write($"\n{questionGoalPoints} ");
        _rewardPoints = int.Parse(Console.ReadLine());
    }

    public override string ToText(Boolean isShort){
        string objectFormatted = "";
        string statusBox = " ";

        if(_completionCount == 1){
            statusBox = "X";
        }

        if(isShort){
            objectFormatted=$"[{statusBox}] {_name} ({_description})";
        }else{
            objectFormatted=$"SimpleGoal,{_name},{_description},{_rewardPoints},{_completionCount}";
        }

        return objectFormatted;
    }
}