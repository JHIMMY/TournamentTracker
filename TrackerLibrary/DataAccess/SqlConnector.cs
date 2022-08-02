﻿using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;
public class SqlConnector : IDataConnector
{
    // TODO - Make the CreatePrize method actually save to the database
    /// <summary>
    /// Saves a new prize to the database.
    /// </summary>
    /// <param name="model">The prize information</param>
    /// <returns>The prize information including now the unique identifier</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
        model.Id = 1;

        return model;
    }
}
