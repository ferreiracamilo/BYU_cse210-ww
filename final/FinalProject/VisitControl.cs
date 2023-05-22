public class VisitControl : Visit{
    private List<string> _valuations;

    public void AddValuation(string valuation){
        _valuations.Add(valuation);
    }
}