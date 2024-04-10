namespace TrackerLibrary.Models;

public class TeamModel
{
    /// <summary>
    /// Represents a list of competitors in a team.
    /// </summary>
    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
}
