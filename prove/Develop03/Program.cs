using System;

class Program{
    static void Main(string[] args){
        Reference ref1_1 = new Reference("Proverbs",3,5);
        Reference ref1_2 = new Reference("Proverbs",3,6);
        Passage pas1_1 = new Passage("Trust in the Lord with all your heart and lean not on your own understanding;", ref1_1);
        Passage pas1_2 = new Passage("in all your ways submit to him and he will make your paths straight.", ref1_2);
        List<Passage> passages1 = new List<Passage>();
        passages1.Add(pas1_1);
        passages1.Add(pas1_2);
        Scripture script1 = new Scripture(passages1);

        Reference ref2_1 = new Reference("Ether",1,7);
        Reference ref2_2 = new Reference("Ether",1,8);
        Reference ref2_3 = new Reference("Ether",1,9);
        Passage pas2_1 = new Passage("Coriantor was the son of Moron.", ref2_1);
        Passage pas2_2 = new Passage("And Moron was the son of Ethem.", ref2_2);
        Passage pas2_3 = new Passage("And Ethem was the son of Ahah.", ref2_3);
        List<Passage> passages2 = new List<Passage>();
        passages2.Add(pas2_1);
        passages2.Add(pas2_2);
        passages2.Add(pas2_3);
        Scripture script2 = new Scripture(passages2);

        Reference ref3_1 = new Reference("Moroni",2,1);
        Passage pas3_1 = new Passage("The words of Christ, which he spake unto his adisciples, the twelve whom he had chosen, as he laid his hands upon them",ref3_1);
        Scripture script3 = new Scripture(pas3_1);

        List<Scripture> scripts = new List<Scripture>();
        scripts.Add(script1);
        scripts.Add(script2);
        scripts.Add(script3);

        Console.WriteLine(script3.GetReferences());
        string verseSample = script3.GetVerses();
        Console.WriteLine(verseSample);
        verseSample = Scripture.ReplaceRandomWordsForUnderscores(verseSample);
        Console.WriteLine(verseSample);
        verseSample = Scripture.ReplaceRandomWordsForUnderscores(verseSample);
        Console.WriteLine(verseSample);
        verseSample = Scripture.ReplaceRandomWordsForUnderscores(verseSample);
        Console.WriteLine(verseSample);
    }
}