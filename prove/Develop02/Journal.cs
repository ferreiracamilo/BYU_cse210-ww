using System.IO; 
public class Journal{
    
    public string _name;
    public List<Entry> _entries = new List<Entry>();

    public void Display(){
        foreach(Entry entry in _entries){
            Console.WriteLine($"{entry}\n");
        }
    }

    public void SaveJournal(){
        string filename = "myFile.csv";

        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach(Entry entry in _entries){
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._reply}"); //save with commas to read it later with LoadJournal to build the objects
            }
        }
        Console.WriteLine("Your prompt/s were saved into a txt file");
    }

    public void LoadJournal(){
        string filename = "myFile.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            string[] parts = line.Split(",");
            Entry newEntry = new Entry(parts[0],parts[1],parts[2]);
            Console.WriteLine(newEntry);
        }
    }
}