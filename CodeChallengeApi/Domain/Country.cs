using System.ComponentModel.DataAnnotations;

namespace CodeChallengeApi.Domain
{
    public class Country : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
