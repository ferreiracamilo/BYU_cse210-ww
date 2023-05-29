public class VisitControl : Visit, IDataSL{
    private List<string> _valuations = new List<string>();

    public void SetValuations(List<string> valuations){
        _valuations = valuations;
    }

    public List<string> GetValuations(){
        return _valuations;
    }

    public void AddValuation(string valuation){
        _valuations.Add(valuation);
    }

    public string StringRepresentation(){
        string valuations = Utils.ListToString(_valuations);
        return $"{_patient};{_date};{_id};{valuations}";
    }
}