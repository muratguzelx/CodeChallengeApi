using CodeChallengeApi.Domain;

namespace CodeChallengeApi.DTOs
{
    public class GetGroupTeamsDto
    { 
        public string Group { get; set; } 
        public string TeamName { get; set; }
        public List<string> TeamNames { get; set; }

    }
}
