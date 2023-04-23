public class Passage{

    private string _text;
    private Reference _reference;

    public Passage (string text, Reference reference){
        _text = text;
        _reference = reference;
    }

    public string GetText(){
        return _text;
    }

    public Reference GetReference(){
        return _reference;
    }
}