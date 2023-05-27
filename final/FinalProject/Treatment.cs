public abstract class Treatment{
    protected DateOnly _startDate;
    protected Pet _patient;
    protected int _id;
    protected Boolean _isCompleted;

    public virtual void SetStartDate(DateOnly date){
        _startDate = date;
    }

    public virtual DateOnly GetStartDate(){
        return _startDate;
    }

    public virtual void SetPatient(Pet pet){
        _patient = pet;
    }

    public virtual Pet GetPatient(){
        return _patient;
    }

    public virtual void SetIsCompleted(Boolean isCompleted){
        _isCompleted = isCompleted;
    }

    public virtual Boolean GetIsCompleted(){
        return _isCompleted;
    }

}