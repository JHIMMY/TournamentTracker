using TrackerLibrary.Models;

namespace TrackerLibrary;
public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
}
