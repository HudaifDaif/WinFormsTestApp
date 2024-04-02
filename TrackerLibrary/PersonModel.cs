namespace TrackerLibrary;

public class PersonModel
{
    /// <summary>
    /// The first name of a competitor.
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// The last name of a competitor.
    /// </summary>
    public required string LastName { get; set; }

    /// <summary>
    /// The email address of a competitor.
    /// </summary>
    public required string EmailAddress { get; set; }
}
