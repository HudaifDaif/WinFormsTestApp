namespace TrackerLibrary.Models;

public class PrizeModel
{
    /// <summary>
    /// Represents the unique identifier for the prize.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Represents the integer identifier for the prize grade,
    /// in relation to other prizes (1 being the highest).
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// Represents the string identifier for the place.
    /// </summary>
    public string PlaceName { get; set; }

    /// <summary>
    /// Represents the decimal value of the prize.
    /// </summary>
    public decimal PrizeAmount { get; set; }

    /// <summary>
    /// Represents a percantage value of the prize from the prize fund. This is a fraction of 1 (0.25 is 25%, 0.69 is 69%, etc.).
    /// </summary>
    public double PrizePercentage { get; set; }

    public PrizeModel()
    {

    }

    /// <summary>
    /// String parameter constructor for use with creating object from user form input.
    /// </summary>
    /// <param name="placeNumber">Parsed to int, defaults to 0.</param>
    /// <param name="placeName">-</param>
    /// <param name="prizeAmount">Parsed to decimal, defaults to 0.</param>
    /// <param name="prizePercentage">Parsed to double, defaults to 0.</param>
    public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
    {
        int placeNumberValue = 0;
        int.TryParse(placeNumber, out placeNumberValue);
        PlaceNumber = placeNumberValue;

        PlaceName = placeName;

        decimal prizeAmountValue = 0;
        decimal.TryParse(prizeAmount, out prizeAmountValue);
        PrizeAmount = prizeAmountValue;

        double prizeAmountPercentage = 0;
        double.TryParse(prizePercentage, out prizeAmountPercentage);
        PrizePercentage = PrizePercentage;
    }
}