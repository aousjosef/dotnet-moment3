namespace Moment_3.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? Username { get; set; }

        public List<User>? Users { get; set; }
    }
}
