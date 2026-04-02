namespace SportsLeague.API.DTOs.Response
{
    public class TournamentSponsorResponseDTO
    {
        public int Id { get; set; } // Tournament
        public int TournamentId { get; set; }
        public string TournamentName { get; set; } = string.Empty;

        public int SponsorId { get; set; } // Sponsor
        public string SponsorName { get; set; } = string.Empty;

        public decimal ContractAmount { get; set; } // TournamentSponsor
        public DateTime JoinedAt { get; set; }
    }
}