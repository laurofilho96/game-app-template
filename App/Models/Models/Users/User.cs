namespace Domain.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public List<User>? Contacts { get; set; }
    }
}
