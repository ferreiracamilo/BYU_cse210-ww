public class VisitControl : Visit, IDataSL{
    private List<string> _valuations;

    public void AddValuation(string valuation){
        _valuations.Add(valuation);
    }

    string IDataSL.StringRepresentation(){
        throw new NotImplementedException();
    }
}