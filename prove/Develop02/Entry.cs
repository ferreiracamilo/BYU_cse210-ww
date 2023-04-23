public class Entry{

    public string _prompt;
    public string _reply;

    public DateTime _date;

    public Entry(string prompt, string reply){
        //This is utilized while writing a new entry
        _prompt = prompt;
        _reply = reply;
        _date = DateTime.Now;
    }

    public Entry(string date, string prompt, string reply){
        //This is utilized to load an entry from the csv
        _prompt = prompt;
        _reply = reply;
        _date = DateTime.Parse(date);
    }

    public override string ToString(){
        //Instead of creating the Display method I preferred to override the ToString
        string entryFormatted = $"Date: {_date.ToShortDateString()} - Prompt: {_prompt} \n{_reply}";
        return entryFormatted;
    }

    public static string RandomPrompt(){
        //Create static method to utilize even without variable created which makes sense for this
        Random rd = new Random();
        int randNum = rd.Next(1,5);
        Dictionary<int, string> dictPrompts = new Dictionary<int, string>(){
            {1, "What would I do better today?"},
            {2, "What's my best achivement today?"},
            {3, "What was the best part of my day?"},
            {4, "Did I try hard enough?"},
            {5, "How did I see the hand of the Lord in my life today?"}
        };
        return dictPrompts[randNum];
    }
}