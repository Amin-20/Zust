using Microsoft.Extensions.Hosting;

namespace AspProjectZust.WebUI.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Fisrtname { get; set;        }
        public string? Lastname { get; set; }
        public string? ImageUrl { get; set; } = "person.jpg";
        public string? Username { get; set; }
        public int LikeCount { get; set; }
        public int FollowersCount { get; set; }
        public int FollowingCount { get; set; }
        public bool IsOnline { get; set; }
        //public virtual ICollection<Friend> Friends
        //public virtual ICollection<Post> Posts
        public string? BackUpEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Occupation { get; set; }
        public string? Gender { get; set; }
        public string? RelationStatus { get; set; }
        public string? BloodGroup { get; set; }
        public string? Language { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
    }
}
