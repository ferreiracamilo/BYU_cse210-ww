public class Pet : IDataSL{
    private string _name;
    private DateOnly _birthdate;
    private string _animalType;
    private string _breed;
    private List<string> _allergies = new List<string>();
    private DateOnly _joinDate;
    private int _id;

    public Pet(string name, DateOnly birthDate, string animalType, string breed, int id){
        _name = name;
        _birthdate = birthDate;
        _animalType = animalType;
        _breed = breed;
        _joinDate = DateOnly.FromDateTime(DateTime.Now);
        _id = id;
    }

    public Pet(string name, DateOnly birthDate, string animalType, string breed, DateOnly joindate, int id){
        _name = name;
        _birthdate = birthDate;
        _animalType = animalType;
        _breed = breed;
        _joinDate = joindate;
        _id = id;
    }

    public Pet(string name, DateOnly birthDate, string animalType, string breed, DateOnly joindate, int id, List<string> allergies){
        _name = name;
        _birthdate = birthDate;
        _animalType = animalType;
        _breed = breed;
        _joinDate = joindate;
        _id = id;
        _allergies = allergies;
    }

    public void SetName(string name){
        _name = name;
    }

    public string GetName(){
        return _name;
    }

    public void SetBirthDate(DateOnly date){
        _birthdate = date;
    }

    public DateOnly GetBirthDate(){
        return _birthdate;
    }

    public void SetAnimalType(string type){
        _animalType = type;
    }

    public string GetAnimalType(){
        return _animalType;
    }

    public void SetBreed(string breed){
        _breed = breed;
    }

    public string GetBreed(){
        return _breed;
    }

    public void SetAllergies(List<string> allergies){
        _allergies = allergies;
    }

    public List<string> GetAllergies(){
        return _allergies;
    }

    public void SetJoinDate(DateOnly date){
        _joinDate = date;
    }

    public DateOnly GetJoinDate(){
        return _joinDate;
    }

    public void SetId(int id){
        _id = id;
    }

    public int GetId(){
        return _id;
    }

    public void AddAllergy(string allergy){
        _allergies.Add(allergy);
    }

    public string StringRepresentation(){
        string allergies = Utils.ListToString(_allergies);
        return $"{_name};{_birthdate};{_animalType};{_breed};{allergies};{_joinDate};{_id}";
    }


}