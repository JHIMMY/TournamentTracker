using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;
public class TextConnector : IDataConnector
{
    // TODO - Wire up the text file creation
    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
        model.Id = 1;

        return model;
    }
}
