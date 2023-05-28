public class Surgery : Treatment, IDataSL{
    private List<string> _procedures;
    private string _anestesiaType;

    public void AddProcedure(string procedure){
        _procedures.Add(procedure);
    }

    public string StringRepresentation(){
        return "a";
    }
}