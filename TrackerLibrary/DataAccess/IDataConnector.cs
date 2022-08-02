using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess;
public interface IDataConnector
{
    PrizeModel CreatePrize(PrizeModel model);
}
