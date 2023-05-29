public class CronicTreatment : Treatment, IDataSL{
    private int _qtyWeeksPrescripted;
    private int _qtyWeeksCompleted;
    private List<Drug> _drugs;

    public void AddDrug(Drug drug){
        _drugs.Add(drug);
    }

    public void SetQtyWeeksPrescripted(int weeks){
        _qtyWeeksPrescripted = weeks;
    }

    public int GetQtyWeeksPrescripted(){
        return _qtyWeeksPrescripted;
    }

    public void SetQtyWeeksCompleted(int weeks){
        _qtyWeeksCompleted = weeks;
    }

    public int GetQtyWeeksCompleted(){
        return _qtyWeeksCompleted;
    }

    public void SetDrugs(List<Drug> drugs){
        _drugs = drugs;
    }

    public List<Drug> GetDrugs(){
        return _drugs;
    }

    public string StringRepresentation(){
        return "a";
    }
}