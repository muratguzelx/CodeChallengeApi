using CodeChallengeApi.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeChallengeApi.DTOs
{
    public class GetTeamDto
    {  
        public string Name { get; set; }
    }
}
