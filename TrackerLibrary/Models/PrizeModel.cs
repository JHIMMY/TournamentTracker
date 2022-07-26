﻿using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models;
public class PrizeModel
{
    public int PlaceNumber { get; set; }
    public string PlaceName { get; set; }
    public decimal PrizeAmount { get; set; }
    public double PrizePercentage { get; set; }
}