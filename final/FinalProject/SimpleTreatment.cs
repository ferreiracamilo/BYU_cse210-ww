public class SimpleTreatment : Treatment, IDataSL{
    private List<Drug> _drugs;

    public void AddDrug(Drug drug){
        _drugs.Add(drug);
    }

    public string StringRepresentation(){
        return "a";
    }
}