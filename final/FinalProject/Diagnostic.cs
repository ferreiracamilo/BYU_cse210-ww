public class Diagnostic : IDataSL{
    private List<string> _reports = new List<string>();
    private Pet _patient;
    private DateOnly _date;
    private int _severity;
    private Vet _vet;
    private int _id;

    public void SetReports(List<string> reports){
        _reports = reports;
    }

    public List<string> GetReports(){
        return _reports;
    }

    public void SetPatient(Pet patient){
        _patient = patient;
    }

    public Pet GetPatient(){
        return _patient;
    }

    public void SetDate(DateOnly date){
        _date = date;
    }

    public DateOnly GetDate(){
        return _date;
    }

    public void SetSeverity(int severity){
        _severity = severity;
    }

    public int GetSeverity(){
        return _severity;
    }

    public void SetVet(Vet vet){
        _vet = vet;
    }

    public Vet GetVet(){
        return _vet;
    }

    public void SetId(int id){
        _id = id;
    }

    public int GetId(){
        return _id;
    }

    public void AddReport(string report){
        _reports.Add(report);
    }

    public string StringRepresentation(){
        string reports = Utils.ListToString(_reports);
        return $"{reports};{_patient.GetId()};{_date};{_severity};{_vet.GetDocid()};{_id}";
    }
}