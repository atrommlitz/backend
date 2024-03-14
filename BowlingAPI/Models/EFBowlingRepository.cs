using Microsoft.EntityFrameworkCore;

namespace BowlingAPI.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext; //create instance of food context file
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingContext = temp;
        }
        //public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;
        public IEnumerable<Bowler> GetBowlersForMarlinsAndSharks()
        {
            return _bowlingContext.Bowlers
                .Include(b => b.Team) // Include the Team navigation property
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToList(); // Execute query and return as list
        }
    }
}
