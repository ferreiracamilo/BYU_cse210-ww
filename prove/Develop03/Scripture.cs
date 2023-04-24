//STORES --> Reference (John 3:16) & text of scripture

// Proverbs 3:5-6
// Proverbs = Book
// 3 = Chapter
// 5-6 Versiculos

public class Scripture{
    private List<Passage> _passages = new List<Passage>();

    public Scripture(Passage passage){
        _passages.Add(passage);
    }

    /// <summary>
    /// The constructor is meant to add passages from same book and chapter, otherwise will fails
    /// </summary>
    public Scripture(List<Passage> passages){
        foreach(Passage passage in passages){
            Reference ref0 = passages[0].GetReference();
            Reference curRef = passage.GetReference();
            bool check = ref0.Equals(curRef);
            if(!ref0.Equals(curRef)){
                throw new ArgumentException("Some of the passages from argument don't belong to same book and/or chapter");
            }
        }
        //_passages.AddRange(passages);
        _passages = passages;
    }

    public string GetReferences(){
        int minVerse=2147483647;
        int maxVerse=0;
        string book = _passages[0].GetReference().GetBook();
        int chapter = _passages[0].GetReference().GetChapter();
        string resRef = ""; //Book Chapter:Range

        if(_passages.Count > 1){
            foreach(Passage passage in _passages){
                int verse = passage.GetReference().GetVerse();
                if(minVerse > verse){
                    minVerse = verse;
                }
                if(maxVerse < verse){
                    maxVerse = verse;
                }
            }
            resRef = $"{book} {chapter}:{minVerse}-{maxVerse}";
        }else{
            minVerse = _passages[0].GetReference().GetVerse();
            resRef = $"{book} {chapter}:{minVerse}";
        }

        return resRef;
    }

    public string GetVerses(){
        string resVerses = "";
        if(_passages.Count > 1){
            // string[] myValues = new string[];
            List<String> myValues = new List<string> ();
            foreach(Passage passage in _passages){
                //myValues.Append(passage.GetText());
                myValues.Add(passage.GetText());
            }
            resVerses = string.Join("; ", myValues);
            // resVerses = string.Join(";",myValues);
        }else{
            resVerses = _passages[0].GetText();
        }
        return resVerses;
    }

    /// <summary>
    /// It will provide a new string exchanging some word for underscores > this apply only to words which don't contain underscore
    /// </summary>
    public static string ReplaceRandomWordsForUnderscores(string phrase){
        //This method is intended to be utilized outside the class without relation to a specific object

        // Split the phrase into words
        string[] words = phrase.Split(' ');

        // Choose a random non-underscore word to replace
        Random random = new Random();
        string wordToReplace = "";
        int index;
        do{
            index = random.Next(words.Length);
            wordToReplace = words[index]; //Load word matching the index obtained on prev line
        } while (wordToReplace.Contains('_'));

        // Replace the chosen word with underscores
        words[index] = new string('_', wordToReplace.Length);

        // Reassemble the phrase and return it
        return string.Join(' ', words); //words were already stored in the order that were written within phrase, therefore join can be utilized
    }

}