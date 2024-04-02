namespace TrackerLibrary;

public class MatchupModel
{
    /// <summary>
    /// Represents the list of teams that will be competing in this matchup.
    /// </summary>
    public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

    /// <summary>
    /// Represents the winner of this matchup.
    /// </summary>
    public TeamModel? Winner { get; set; }

    /// <summary>
    /// Represents which round this matchup takes place in.
    /// </summary>
    public int MatchupRound { get; set; }

}