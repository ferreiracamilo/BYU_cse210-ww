public static class Utils{
    public static string listToString(List<string> list){
        string finalword = "";
        for(int i=0; i<list.Count(); i++){
            if(i != list.Count()-1){
                finalword = list[i] + ",";
            }else{
                finalword = list[i];
            }
        }
        return finalword;
    }

    public static string dateToString(DateOnly date){
        return date.ToString("dd/MM/yyyy");
    }

    public static DateOnly stringToDate(string sDate){
        return DateOnly.Parse(sDate);
    }
}