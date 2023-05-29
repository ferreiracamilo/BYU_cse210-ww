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

    public void AddAllergy(string allergy){
        _allergies.Add(allergy);
    }

    public string StringRepresentation(){
        string allergies = Utils.ListToString(_allergies);
        return $"{_name};{_birthdate};{_animalType};{_breed};{allergies};{_joinDate};{_id}";
    }


}