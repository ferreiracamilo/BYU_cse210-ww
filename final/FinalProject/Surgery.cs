public class Surgery : Treatment, IDataSL{
    private List<string> _procedures = new List<string>();
    private string _anestesiaType;

    public Surgery(Pet patient, int id, string anestesia, Vet vet){
        _startDate = DateOnly.FromDateTime(DateTime.Now);
        _patient = patient;
        _id = id;
        _isCompleted = true;
        _anestesiaType = anestesia;
        _vet = vet;
    }

    public override string ToString(){
        string status = "Incomplete";
        if(_isCompleted){
            status = "Complete";
        }

        string procedures = Utils.ListToString(_procedures);

        return $"<<Treatment: Surgery>> ID: {_id} - Status: {status} - Start Date: {_startDate} - Anestesia Type: {_anestesiaType} \nProcedures:{procedures} \n{_vet} \n{_patient}";
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
        return $"{_startDate};{_patient.GetId()};{_vet.GetDocid()};{_id};{_isCompleted};{procedures};{_anestesiaType}";
    }
}