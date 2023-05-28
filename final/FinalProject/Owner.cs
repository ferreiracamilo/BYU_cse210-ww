using System.Text.RegularExpressions;

public class Owner : IDataSL{

    private List<Pet> _petList;
    private int _docId;
    private string _monthlyFeePaymentMethod;
    private string _phoneNumber;
    private string _address;
    private string _email;

    public void AddPet(Pet pet){
        _petList.Add(pet);
    }

    public string StringRepresentation(){
        return "a";
    }
}