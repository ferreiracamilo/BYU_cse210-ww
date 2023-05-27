public class Surgery : Treatment, IDataSL{
    private List<string> _procedures;
    private string _anestesiaType;

    string IDataSL.StringRepresentation(){
        throw new NotImplementedException();
    }
}