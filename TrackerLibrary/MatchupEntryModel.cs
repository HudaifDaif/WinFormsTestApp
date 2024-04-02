namespace TrackerLibrary;

public class MatchupEntryModel
{
    /// <summary>
    /// Represents one team in the matchup.
    /// </summary>
    public required TeamModel TeamCompeting { get; set; }

    /// <summary>
    /// Represents this team's score in the matchup.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Represents the matchup that this team had won, just before this round.
    /// </summary>
    public MatchupModel? ParentMatchup { get; set; }
}