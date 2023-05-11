public class ReflectionActivity : Activity{

    private List<string> _prompts = new List<string> {"Think of a time when you did something really difficult","Think of a time when you treat badly a relative","Think if you could've done any better during your day","Think of a time when you feel sad and how could you faced this in the present"};
    private List<string> _questions = new List<string> {"What is your favorite thing about this experience?","How did you feel when it was completed?","Would you like to be asked about something else?","Did you reflect and learn with this experience?"};
    public ReflectionActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    /// <summary>
    /// Method will print in console a prompt and wait for user response, after 2 questions are prompt giving half of given duration to reflect about them
    /// </summary>
    /// <param name="duration">Duration in seconds to perform this method</param>
    public override void ExecuteActivity(int duration){
        GetReady();

        Console.WriteLine("\nConsider the following prompt");
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");

        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        ConsoleKeyInfo c = Console.ReadKey();
        if(c.Key == ConsoleKey.Enter){
            Console.WriteLine("\n\nNow ponder each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            CounterAnimation(5);
        }else{
            throw new Exception("You pressed a different key, execute application again and do not forget to follow indications.");
        }

        Console.Clear();

        foreach(string question in GetDistinctQuestions(2)){
            Console.Write($"\n{question} ");
            SpinnerAnimation(duration/2);
        }

        CompleteMessage(duration);
    }

    /// <summary>
    /// Get a random string value from class attribute 'prompts' list
    /// </summary>
    /// <returns>A string value from prompts list</returns>
    private string GetRandomPrompt(){
        Random random = new Random();
        int promptIndex  = random.Next(0, _prompts.Count-1);

        return _prompts[promptIndex];
    }

    /// <summary>
    /// Method prepared to provide distinct("unique") values from class attribute 'questions' list
    /// </summary>
    /// <param name="distinctQty">Quantity of questions to return</param>
    /// <returns>List of string containing different questions</returns>
    private List<string> GetDistinctQuestions(int distinctQty){
        Random random = new Random();
        int[] questionDistinctIndexes = Enumerable.Range(0, _questions.Count-1).OrderBy(x => random.Next()).Take(distinctQty).ToArray();
        List<string> questionList = new List<string>();

        foreach(int questionIndex in questionDistinctIndexes){
            questionList.Add(_questions[questionIndex]);
        }

        return questionList;
    }
}