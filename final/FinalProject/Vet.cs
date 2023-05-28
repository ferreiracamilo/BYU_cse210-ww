using System.Text.RegularExpressions;

public class Vet : IDataSL{
    private int _docId;
    private string _phoneNumber;
    private string _address;
    private string _email;
    private DateOnly _startDate;
    private bool _isActive;

    public Vet(int docId, string phoneNumber, string address, string email){
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
        _startDate = DateOnly.FromDateTime(DateTime.Now);
        _isActive = true;
    }

    public string StringRepresentation(){
        return $"{_docId};{_phoneNumber};{_address};{_email};{_startDate};{_isActive}";
    }
}