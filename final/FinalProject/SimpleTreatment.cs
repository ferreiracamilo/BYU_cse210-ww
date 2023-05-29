public class SimpleTreatment : Treatment, IDataSL{
    private List<Drug> _drugs = new List<Drug>();

    public void SetDrugs(List<Drug> drugs){
        _drugs = drugs;
    }

    public List<Drug> GetDrugs(){
        return _drugs;
    }

    public void AddDrug(Drug drug){
        _drugs.Add(drug);
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
        string drugs = SimpleTreatment.DrugListToString(_drugs);
        return $"{_startDate};{_patient};{_id};{_isCompleted};{drugs}";
    }
}