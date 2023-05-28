public class CronicTreatment : Treatment, IDataSL{
    private int _qtyWeeksPrescripted;
    private int _qtyWeeksCompleted;
    private List<Drug> _drugs;

    public void AddDrug(Drug drug){
        _drugs.Add(drug);
    }

    public string StringRepresentation(){
        return "a";
    }
}