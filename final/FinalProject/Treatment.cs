public abstract class Treatment{
    protected DateOnly _startDate;
    protected Pet _patient;
    protected int _id;
    protected bool _isCompleted;
    protected Vet _vet;

    public virtual void SetVet(Vet vet){
        _vet = vet;       
    }

    public virtual Vet GetVet(){
        return _vet;
    }

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

    public virtual void SetIsCompleted(bool isCompleted){
        _isCompleted = isCompleted;
    }

    public virtual bool GetIsCompleted(){
        return _isCompleted;
    }

    public virtual void SetId(int id){
        _id = id;
    }

    public virtual int GetId(){
        return _id;
    }
}