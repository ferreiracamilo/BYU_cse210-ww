using System.Text.RegularExpressions;

public class Vet : IDataSL{
    private int _docId;
    private string _phoneNumber;
    private string _address;
    private string _email;
    private DateOnly _startDate;
    private bool _isActive;


    /// <summary>
    /// Constructor meant to initiliaze a new object that will set by default start date as today and status as active
    /// </summary>
    /// <param name="docId">int</param>
    /// <param name="phoneNumber">string</param>
    /// <param name="address">string</param>
    /// <param name="email">string</param>
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

    /// <summary>
    /// Constructor meant to initiliaze a new object that will set by default status as active
    /// </summary>
    /// <param name="docId">int</param>
    /// <param name="phoneNumber">string</param>
    /// <param name="address">string</param>
    /// <param name="email">string</param>
    /// <param name="date">DateOnly</param>
    public Vet(int docId, string phoneNumber, string address, string email, DateOnly date){
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
        _startDate = date;
        _isActive = true;
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
    public Vet(int docId, string phoneNumber, string address, string email, DateOnly date, bool status){
        _docId = docId;
        _phoneNumber = phoneNumber;
        _address = address;
        _email = email;
        _startDate = date;
        _isActive = status;
    }

    public string StringRepresentation(){
        return $"{_docId};{_phoneNumber};{_address};{_email};{_startDate};{_isActive}";
    }
}