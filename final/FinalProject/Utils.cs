using System.Text.RegularExpressions;

public static class Utils{

    /// <summary>
    /// Turn a List<String> into one string concatenate with ','
    /// </summary>
    /// <param name="list">List<string></param>
    /// <returns>string</returns>
    public static string ListToString(List<string> list){
        string finalword = "";
        if(list.Count()>0){
            for(int i=0; i<list.Count(); i++){
                if(i != list.Count()-1){
                    finalword += list[i] + ",";
                }else{
                    finalword += list[i];
                }
            }
        }else{
            finalword = " ";
        }
        
        return finalword;
    }

    /// <summary>
    /// Turn a string into a DateOnly data
    /// </summary>
    /// <param name="sDate">string</param>
    /// <returns>string</returns>
    public static DateOnly StringToDate(string sDate){
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
    /// <returns>bool</returns>
    public static bool ValidatePhone(string phone){
        if (string.IsNullOrEmpty(phone))
            return false;
        
        foreach (char c in phone)
        {
            if (!char.IsDigit(c) && c != '-')
                return false;
        }
        
        return true;
    }

    /// <summary>
    /// Generate an int Id based on current datetime to assure will be unique
    /// </summary>
    /// <returns>int</returns>
    public static int CreateUniqueId(){
    DateTime now = DateTime.Now;

    int month = now.Month;
    int day = now.Day;
    int year = now.Year;
    int hour = now.Hour;
    int minutes = now.Minute;
    int seconds = now.Second;

    int id = int.Parse($"{month:00}{day:00}{year}{hour:00}{minutes:00}{seconds:00}");

    return id;
    }
}