public class VisitDiscomfort : Visit, IDataSL{
    private List<string> _synthoms = new List<string>();

    public VisitDiscomfort(Pet pet, int id){
        _date = DateOnly.FromDateTime(DateTime.Now);
        _id = id;
        _patient = pet;
    }

    public override string ToString(){
        string synthoms = Utils.ListToString(_synthoms);
        return $"<<Visit Discomfort>> ID: {_id} - Date: {_date} - Valuations: {synthoms} \n{_patient}";
    }

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