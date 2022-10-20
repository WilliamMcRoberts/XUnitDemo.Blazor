namespace XUnitDemo.Blazor.Data;

public class PersonModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}
