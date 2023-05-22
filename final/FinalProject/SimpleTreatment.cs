public class SimpleTreatment : Treatment{
    private List<Drug> _drugs;

    public void AddDrug(Drug drug){
        _drugs.Add(drug);
    }
}