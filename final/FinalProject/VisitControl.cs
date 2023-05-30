public class VisitControl : Visit, IDataSL{
    private List<string> _valuations = new List<string>();

    public VisitControl(Pet pet, int id){
        _date = DateOnly.FromDateTime(DateTime.Now);
        _id = id;
        _patient = pet;
    }

    public override string ToString(){
        string valuations = Utils.ListToString(_valuations);
        return $"<<Visit: Control>> ID: {_id} - Date: {_date} - Valuations: {_valuations} \n{_patient}";
    }
    
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