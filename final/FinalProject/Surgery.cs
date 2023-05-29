public class Surgery : Treatment, IDataSL{
    private List<string> _procedures;
    private string _anestesiaType;

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
        return "a";
    }
}