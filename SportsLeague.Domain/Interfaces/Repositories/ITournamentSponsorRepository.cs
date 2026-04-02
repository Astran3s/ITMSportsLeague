using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Interfaces.Repositories
{
    public interface ITournamentSponsorRepository : IGenericRepository<TournamentSponsor>
    {
        // Own methods
        Task<TournamentSponsor?> GetBySponsorAndTournamentAsync(int sponsorId, int tournamentId);

        // Recovery of all sponsorships
        Task<IEnumerable<TournamentSponsor>> GetBySponsorIdAsync(int sponsorId);

        // Recovery of all partners
        Task<IEnumerable<TournamentSponsor>> GetByTournamentIdAsync(int tournamentId);
    }
}