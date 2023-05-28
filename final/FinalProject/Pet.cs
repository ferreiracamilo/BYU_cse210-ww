public class Pet : IDataSL{
    private string _name;
    private DateOnly _birthdate;
    private string _animalType;
    private string _breed;
    private List<string> _allergies;
    private DateOnly _joinDate;
    private int _id;

    public string StringRepresentation(){
        return "a";
    }
}