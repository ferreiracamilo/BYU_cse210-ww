public class Drug : IDataSL{
    private string _name;
    private string _type;
    private string _presentation;
    private int _id;

    string IDataSL.StringRepresentation(){
        throw new NotImplementedException();
    }
}