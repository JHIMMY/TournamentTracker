using TrackerLibrary.Models;

namespace TrackerLibrary;
public class TextConnector : IDataConnection
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
