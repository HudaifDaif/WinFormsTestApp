namespace TrackerLibrary.Models;

public class TournamentModel
{
    /// <summary>
    /// The name of the tournament.
    /// </summary>
    public required string TournamentName { get; set; }

    /// <summary>
    /// Represents the decimal value of the entry fee required
    /// to compete in the tournament.
    /// </summary>
    public decimal EntryFee { get; set; }

    /// <summary>
    /// Represents the list of teams that have been entered
    /// into the tournament.
    /// </summary>
    public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

    /// <summary>
    /// Represents the list of prizes that will be been awarded.
    /// </summary>
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

    /// <summary>
    /// Represents the list of rounds that will be played. Each round will be a list of matchups.
    /// </summary>
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
}
