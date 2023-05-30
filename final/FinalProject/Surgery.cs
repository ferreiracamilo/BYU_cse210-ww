public class Surgery : Treatment, IDataSL{
    private List<string> _procedures = new List<string>();
    private string _anestesiaType;

    public Surgery(Pet patient, int id, string anestesia){
        _startDate = DateOnly.FromDateTime(DateTime.Now);
        _patient = patient;
        _id = id;
        _isCompleted = true;
        _anestesiaType = anestesia;
    }

    public void SetProcedures(List<string> procedures){
        _procedures = procedures;
    }

    public List<string> GetProcedures(){
        return _procedures;
    }

    public void SetAnestesia(string anestesia){
        _anestesiaType = anestesia;
    }

    public string GetAnestesia(){
        return _anestesiaType;
    }

    public void AddProcedure(string procedure){
        _procedures.Add(procedure);
    }

    public string StringRepresentation(){
        string procedures = Utils.ListToString(_procedures);
        return $"{_startDate};{_patient};{_id};{_isCompleted};{procedures};{_anestesiaType}";
    }
}