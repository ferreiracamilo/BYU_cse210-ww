public class VisitDiscomfort : Visit, IDataSL{
    private List<string> _synthoms;

    public void AddSynthom(string synthom){
        _synthoms.Add(synthom);
    }

    public string StringRepresentation(){
        return "a";
    }
}