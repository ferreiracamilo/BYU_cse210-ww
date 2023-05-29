using System.Text.RegularExpressions;

public class Owner : IDataSL{

    private List<Pet> _petList = new List<Pet>();
    private int _docId;
    private string _monthlyFeePaymentMethod;
    private string _phoneNumber;
    private string _address;
    private string _email;

    /// <summary>
    /// Constructor meant to initiliaze a new object that will set by default start date as today and status as active
    /// </summary>
    /// <param name="docId">int</param>
    /// <param name="phoneNumber">string</param>
    /// <param name="address">string</param>
    /// <param name="email">string</param>
    /// <param name="monthlyFeePaymentMethod">string</param>
    public Owner(int docId, string phoneNumber, string address, string email, string monthlyFeePaymentMethod){
        if(!Utils.ValidateEmail(email)){
            throw new EmailValidationException("Email argument is not an actual email address.");
        }
        if(!Utils.ValidateEmail(phoneNumber)){
            throw new PhoneNumberValidationException("Phone argument is not an actual phone number.");
        }
        _docId = docId;
        _phoneNumber = phoneNumber;
        _address = address;
        _email = email;
        _monthlyFeePaymentMethod = monthlyFeePaymentMethod;
    }

    /// <summary>
    /// Constructor meant to create objects for later load functionality
    /// </summary>
    /// <param name="docId">int</param>
    /// <param name="phoneNumber">string</param>
    /// <param name="address">string</param>
    /// <param name="email">string</param>
    /// <param name="date">DateOnly</param>
    /// <param name="status">bool</param>
    public Owner(int docId, string phoneNumber, string address, string email, string monthlyFeePaymentMethod, List<Pet> petList){
        _docId = docId;
        _phoneNumber = phoneNumber;
        _address = address;
        _email = email;
        _petList = petList;
    }

    public void SetPetList(List<Pet> petList){
        _petList = petList;
    }

    public List<Pet> GetPetList(){
        return _petList;
    }

    public void SetDocId(int docId){
        _docId = docId;
    }

    public int GetDocId(){
        return _docId;
    }

    public void SetMonthlyPaymentMethd(string paymentMethod){
        _monthlyFeePaymentMethod = paymentMethod;
    }

    public string GetMonthlyPaymentMethd(){
        return _monthlyFeePaymentMethod;
    }

    public void SetPhoneNumber(string phoneNumber){
        if(!Utils.ValidatePhone(phoneNumber)){
            throw new PhoneNumberValidationException("Phone argument is not an actual phone number.");
        }
        _phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber(){
        return _phoneNumber;
    }

    public void SetAddress(string address){
        _address = address;
    }

    public string GetAddress(){
        return _address;
    }

    public void SetEmail(string email){
        if(!Utils.ValidateEmail(email)){
            throw new EmailValidationException("Email argument is not an actual email address.");
        }
        _email = email;
    }

    public string GetEmail(){
        return _email;
    }

    public void AddPet(Pet pet){
        _petList.Add(pet);
    }

    /// <summary>
    /// Turn a List<Pet> into one string concatenate with ','
    /// </summary>
    /// <param name="list">List<Pet></param>
    /// <returns>string</returns>
    private static string PetListToString(List<Pet> list){
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
        string pets = Owner.PetListToString(_petList);
        return $"{pets};{_docId};{_monthlyFeePaymentMethod};{_phoneNumber};{_address};{_email}";
    }
}