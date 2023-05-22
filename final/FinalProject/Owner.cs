using System.Text.RegularExpressions;

public class Owner : IValidationData{

    private List<Pet> _petList;
    private int _docId;
    private string _monthlyFeePaymentMethod;
    private string _phoneNumber;
    private string _address;
    private string _email;

    public void AddPet(Pet pet){
        _petList.Add(pet);
    }
    
    Boolean IValidationData.ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))

            return false;
        
        // Regular expression pattern to validate email addresses
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        
        return Regex.IsMatch(email, pattern);
    }

    Boolean IValidationData.ValidatePhone(string phone)
    {
        if (string.IsNullOrEmpty(phone))
            return false;
        
        foreach (char c in phone)
        {
            if (!char.IsDigit(c) && c != '-')
                return false;
        }
        
        return true;
    }
}