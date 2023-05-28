public class Pet : IDataSL{
    private string _name;
    private DateOnly _birthdate;
    private string _animalType;
    private string _breed;
    private List<string> _allergies;
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

    public string StringRepresentation(){
        return $"{_name}";
    }


}