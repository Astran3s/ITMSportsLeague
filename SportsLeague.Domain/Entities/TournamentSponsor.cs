using SportsLeague.Domain.Entities;

namespace SportsLeague.Domain.Entities
{
    public class TournamentSponsor : AuditBase
    {
        public int TournamentId { get; set; }
        public int SponsorId { get; set; }
        public decimal ContractAmount { get; set; }
        public DateTime JoinedAt { get; set; }

        // conexion a tablas
        public Tournament Tournament { get; set; } = null!; 
        public Sponsor Sponsor { get; set; } = null!;
    }
}