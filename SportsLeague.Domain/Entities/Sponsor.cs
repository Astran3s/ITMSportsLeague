//using System.Collections.Generic;
using SportsLeague.Domain.Enums;

namespace SportsLeague.Domain.Entities
{
    public class Sponsor : AuditBase
    {
        // Atributes
        public string Name { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string? Phone { get; set; } // not required
        public string? WebsiteUrl { get; set; } // not required

        public SponsorCategory Category { get; set; } // Enum (SponsorCategory)

        //Navigation 
        public ICollection<TournamentSponsor> TournamentSponsors { get; set; } = new List<TournamentSponsor>();
    }
} // Phase 4