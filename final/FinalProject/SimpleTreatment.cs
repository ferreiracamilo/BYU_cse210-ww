public class SimpleTreatment : Treatment, IDataSL{
    private List<Drug> _drugs = new List<Drug>();

    public SimpleTreatment(Pet patient, int id, Vet vet){
        _startDate = DateOnly.FromDateTime(DateTime.Now);
        _patient = patient;
        _id = id;
        _isCompleted = true;
        _vet = vet;
    }

    public override string ToString(){
        string status = "Incomplete";
        if(_isCompleted){
            status = "Complete";
        }

        string drugs = SimpleTreatment.DrugListToString(_drugs);

        return $"<<Treatment: Cronic Treatment>> ID: {_id} - Status: {status} - Start Date: {_startDate} \nDrugs: {drugs} \n{_vet} \n{_patient}";
    }

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
        return $"{_startDate};{_patient.GetId()};{_vet.GetDocid()};{_id};{_isCompleted};{drugs}";
    }
}