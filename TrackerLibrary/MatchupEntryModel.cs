namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        public required TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel? ParentMatchup { get; set; }
    }
}