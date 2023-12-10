using System.ComponentModel.DataAnnotations;

namespace CodeChallengeApi.Domain
{
    public class Group : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<GroupTeam> GroupTeams { get; set; }
    }
}
