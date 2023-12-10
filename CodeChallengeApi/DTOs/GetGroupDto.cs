namespace CodeChallengeApi.DTOs
{
    public class GetGroupDto
    {
        public string GroupName { get; set; }
        public List<GetTeamDto> Teams { get; set; }
    }
}
