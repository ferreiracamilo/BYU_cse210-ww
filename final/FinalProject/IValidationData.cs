interface IValidationData
{
    /// <summary>
    /// Validate if an email address is correct
    /// </summary>
    /// <param name="email">String</param>
    /// <returns>Boolean</returns>
    Boolean ValidateEmail(string email);

    /// <summary>
    /// Validate if a given string is a phone number by assuring contains only digits and/or -
    /// </summary>
    /// <param name="phone">String</param>
    /// <returns>Boolean</returns>
    Boolean ValidatePhone(string phone);
}