using CodeChallengeApi.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeChallengeApi.DTOs
{
    public class GetTeamsDto : BaseEntity
    { 
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Name { get; set; }
    }
}
