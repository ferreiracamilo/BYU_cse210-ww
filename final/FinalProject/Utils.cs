using System.Text.RegularExpressions;

public static class Utils{

    /// <summary>
    /// Turn a List<String> into one string concatenate with ','
    /// </summary>
    /// <param name="list">List<string></param>
    /// <returns>string</returns>
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

    /// <summary>
    /// Turn a string into a Date
    /// </summary>
    /// <param name="date">DateOnly</param>
    /// <returns>string</returns>
    public static string dateToString(DateOnly date){
        return date.ToString("dd/MM/yyyy");
    }

    /// <summary>
    /// Turn a string into a DateOnly data
    /// </summary>
    /// <param name="sDate">string</param>
    /// <returns>string</returns>
    public static DateOnly stringToDate(string sDate){
        return DateOnly.Parse(sDate);
    }

    /// <summary>
    /// Validate if an email address is correct
    /// </summary>
    /// <param name="email">String</param>
    /// <returns>bool</returns>
    public static bool ValidateEmail(string email){
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