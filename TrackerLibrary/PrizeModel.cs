namespace TrackerLibrary;

public class PrizeModel
{
    /// <summary>
    /// Represents the integer identifier for the prize.
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// Represents the string identifier for the place.
    /// </summary>
    public required string PlaceName { get; set; }

    /// <summary>
    /// Represents the decimal value of the prize.
    /// </summary>
    public decimal PrizeAmount { get; set; }
}