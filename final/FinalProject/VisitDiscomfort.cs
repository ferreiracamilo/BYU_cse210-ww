public class VisitDiscomfort : Visit, IDataSL{
    private List<string> _synthoms = new List<string>();

    public void SetSynthoms(List<string> synthoms){
        _synthoms = synthoms;
    }

    public List<string> GetSynthoms(){
        return _synthoms;
    }

    public void AddSynthom(string synthom){
        _synthoms.Add(synthom);
    }

    public string StringRepresentation(){
        string synthoms = Utils.ListToString(_synthoms);
        return $"{_patient};{_date};{_id};{synthoms}";
    }
}