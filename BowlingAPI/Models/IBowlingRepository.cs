namespace BowlingAPI.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetBowlersForMarlinsAndSharks();
    }
}
