using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeChallengeApi.Domain
{
    public class Team : BaseEntity
    {
        [Required, ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<GroupTeam> GroupTeams { get; set; }
    }
}
