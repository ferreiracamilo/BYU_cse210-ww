public class VisitDiscomfort : Visit, IDataSL{
    private List<string> _synthoms;

    public void AddSynthom(string synthom){
        _synthoms.Add(synthom);
    }

    string IDataSL.StringRepresentation(){
        throw new NotImplementedException();
    }
}