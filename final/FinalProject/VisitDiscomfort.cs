public class VisitDiscomfort : Visit{
    private List<string> _synthoms;

    public void AddSynthom(string synthom){
        _synthoms.Add(synthom);
    }
}