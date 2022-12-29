namespace WebAPI.Models.User
{
    public class UserDetails
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? City { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
