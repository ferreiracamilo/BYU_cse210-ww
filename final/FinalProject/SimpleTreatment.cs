public class SimpleTreatment : Treatment, IDataSL{
    private List<Drug> _drugs;

    public void SetDrugs(List<Drug> drugs){
        _drugs = drugs;
    }

    public List<Drug> GetDrugs(){
        return _drugs;
    }

    public void AddDrug(Drug drug){
        _drugs.Add(drug);
    }

    public string StringRepresentation(){
        return "a";
    }
}