using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models;
public class PrizeModel
{
    /// <summary>
    /// The unique identifier for the prize
    /// </summary>
    public int Id { get; set; }
    public int PlaceNumber { get; set; }
    public string PlaceName { get; set; }
    public decimal PrizeAmount { get; set; }
    public double PrizePercentage { get; set; }

    public PrizeModel() { }

    public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
    {
        // parse to the correct types
        int placeNumberValue;
        int.TryParse(placeNumber, out placeNumberValue);
        PlaceNumber = placeNumberValue;


        PlaceName = placeName;


        decimal prizeAmountValue;
        decimal.TryParse(prizeAmount, out prizeAmountValue);
        PrizeAmount = prizeAmountValue;

        double prizePercentageValue;
        double.TryParse(prizePercentage, out prizePercentageValue);
        PrizePercentage = prizePercentageValue;
    }
}
