public class Drug : IDataSL{
    private string _name;
    private string _type;
    private string _presentation;
    private int _id;

    public Drug(string name, string type, string presentation, int id){
        _name = name;
        _type = type;
        _presentation = presentation;
        _id = id;
    }

    public override string ToString(){
        return "a";
    }

    public void SetName(string name){
        _name = name;
    }

    public string GetName(){
        return _name;
    }

    public void SetType(string type){
        _type = type;
    }

    public string GetTypeAttr(){
        return _type;
    }

    public void SetPresentation(string presentation){
        _presentation = presentation;
    }

    public string GetPresentation(){
        return _presentation;
    }

    public void SetId(int id){
        _id = id;
    }

    public int GetId(){
        return _id;
    }

    public string StringRepresentation(){
        return $"{_name};{_type};{_presentation};{_id}";
    }
}