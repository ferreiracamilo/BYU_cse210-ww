public class Diagnostic : IDataSL{
    private List<string> _reports;
    private Pet _patient;
    private DateOnly _date;
    private int _severity;
    private Vet _vet;
    private int _id;

    public void AddReport(string report){
        _reports.Add(report);
    }

    public string StringRepresentation(){
        return "a";
    }
}