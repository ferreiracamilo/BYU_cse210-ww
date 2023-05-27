using System.Text.RegularExpressions;

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

    /// <summary>
    /// Validate if an email address is correct
    /// </summary>
    /// <param name="email">String</param>
    /// <returns>Boolean</returns>
    public static Boolean ValidateEmail(string email){
        if (string.IsNullOrWhiteSpace(email))

            return false;
        
        // Regular expression pattern to validate email addresses
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        
        return Regex.IsMatch(email, pattern);
    }

    /// <summary>
    /// Validate if a given string is a phone number by assuring contains only digits and/or -
    /// </summary>
    /// <param name="phone">String</param>
    /// <returns>Boolean</returns>
    public static Boolean ValidatePhone(string phone){
        if (string.IsNullOrEmpty(phone))
            return false;
        
        foreach (char c in phone)
        {
            if (!char.IsDigit(c) && c != '-')
                return false;
        }
        
        return true;
    }
}