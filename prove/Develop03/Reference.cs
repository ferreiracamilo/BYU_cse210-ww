public class Reference : IEquatable<Reference>{

    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetBook(){
        return _book;
    }

    public int GetChapter(){
        return _chapter;
    }

    public int GetVerse(){
        return _verse;
    }

    /// <summary>
    /// Compare if two reference objects belong to same book and chapter
    /// </summary>
    public bool Equals(Reference other){
        bool result = false;
        if(_book.ToLower().Equals(other.GetBook().ToLower()) && _chapter == other.GetChapter()){
            result = true;
        }
        // TODO: Compare Members and return false if not the same
        return result;
    }
}