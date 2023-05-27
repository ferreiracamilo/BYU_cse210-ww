using System.Text.RegularExpressions;

public class Vet : IDataSL{
    private int _docId;
    private string _phoneNumber;
    private string _address;
    private string _email;
    private DateOnly _startDate;
    private Boolean _isActive;

    string IDataSL.StringRepresentation(){
        throw new NotImplementedException();
    }
}