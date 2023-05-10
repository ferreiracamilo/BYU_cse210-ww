public class ReflectionActivity : Activity{

    private List<string> prompts = new List<string> {"Think of a time when you did something really difficult","Think of a time when you treat badly a relative","Think if you could've done any better during your day","Think of a time when you feel sad and how could you faced this in the present"};
    private List<string> questions = new List<string> {"What is your favorite thing about this experience?","How did you feel when it was completed?","Would you like to be asked about something else?","Did you reflect and learn with this experience?"};
    public ReflectionActivity(string activityName, string description) : base (activityName, description){
        _activityName = activityName;
        _description = description;
    }

    public override void ExecuteActivity(int duration){
        getReady();

        Console.WriteLine("\nConsider the following prompt");
        Console.WriteLine($"\n--- {getRandomPrompt()} ---");

        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        ConsoleKeyInfo c = Console.ReadKey();
        if(c.Key == ConsoleKey.Enter){
            Console.WriteLine("\n\nNow ponder each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            counterAnimation(5);
        }else{
            throw new Exception("You pressed a different key, execute application again and do not forget to follow indications.");
        }

        Console.Clear();

        foreach(string question in getDistinctQuestions(2)){
            Console.Write($"\n{question} ");
            spinnerAnimation(duration/2);
        }

        completeMessage(duration);
    }

    private string getRandomPrompt(){
        Random random = new Random();
        int promptIndex  = random.Next(0, prompts.Count-1);

        return prompts[promptIndex];
    }

    private List<string> getDistinctQuestions(int distinctQty){
        Random random = new Random();
        int[] questionDistinctIndexes = Enumerable.Range(0, questions.Count-1).OrderBy(x => random.Next()).Take(distinctQty).ToArray();
        List<string> questionList = new List<string>();

        foreach(int questionIndex in questionDistinctIndexes){
            questionList.Add(questions[questionIndex]);
        }

        return questionList;
    }
}