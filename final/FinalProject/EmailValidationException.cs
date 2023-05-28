public class EmailValidationException : Exception
{
    public EmailValidationException(string message) : base(message)
    {
    }

    public override string ToString()
    {
        // Customize the string representation of the exception
        // to include additional information if needed
        return $"EmailValidationException: {Message}";
    }
}