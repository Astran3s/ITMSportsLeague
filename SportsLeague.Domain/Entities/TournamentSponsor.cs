//using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Entities
{
    public class TournamentSponsor : AuditBase
    {
        // foreign Keys
        public int TournamentId { get; set; }
        public int SponsorId { get; set; }

        // contract data (payload)
        public decimal ContractAmount { get; set; }
        public DateTime JoinedAt { get; set; }

        // relationship Navigation Properties 
        public Tournament Tournament { get; set; } = null!; 
        public Sponsor Sponsor { get; set; } = null!;
    }
}