public class Visit{
    protected Pet _patient;
    protected DateOnly _date;
    protected int _id;

    public virtual void SetPatient(Pet patient){
        _patient = patient;
    }

    public virtual Pet GetPatient(){
        return _patient;
    }

    public virtual void SetDate(DateOnly date){
        _date = date;
    }

    public virtual DateOnly GetDate(){
        return _date;
    }

    public virtual void SetId(int id){
        _id = id;
    }

    public virtual int GetId(){
        return _id;
    }
}