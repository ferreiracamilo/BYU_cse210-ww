public class CronicTreatment : Treatment, IDataSL{
    private int _qtyWeeksPrescripted;
    private int _qtyWeeksCompleted;
    private List<Drug> _drugs = new List<Drug>();

    public CronicTreatment(Pet patient, int id, int qtyWeeksPrescripted, Vet vet){
        _startDate = DateOnly.FromDateTime(DateTime.Now);
        _patient = patient;
        _id = id;
        _qtyWeeksPrescripted = qtyWeeksPrescripted;
        _qtyWeeksCompleted = 0;
        _isCompleted = false;
        _vet = vet;
    }

    public override string ToString(){
        return "a";
    }

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

    /// <summary>
    /// Turn a List<Drug> into one string concatenate with ','
    /// </summary>
    /// <param name="list">List<Drug></param>
    /// <returns>string</returns>
    private static string DrugListToString(List<Drug> list){
        string finalword = "";
        if(list.Count()>0){
            for(int i=0; i<list.Count(); i++){
                if(i != list.Count()-1){
                    finalword += list[i].GetId() + ",";
                }else{
                    finalword += list[i].GetId();
                }
            }
        }else{
            finalword = " ";
        }
        
        return finalword;
    }

    public string StringRepresentation(){
        string drugs = CronicTreatment.DrugListToString(_drugs);
        return $"{_startDate};{_patient.GetId()};{_vet.GetDocid()};{_id};{_isCompleted};{_qtyWeeksPrescripted};{_qtyWeeksCompleted};{drugs}";
    }
}