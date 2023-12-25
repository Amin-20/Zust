using Microsoft.AspNetCore.Identity;
using Zust.Core.Abstraction;

namespace Zust.Entities.Models
{
    public class CustomIdentityUser : IdentityUser, IEntity
    {
        public string? Fisrtname { get; set; }
        public string? Lastname { get; set; }
        public string? ImageUrl { get; set; } = "person.jpg";
        public int LikeCount { get; set; }
        public int FollowersCount { get; set; }
        public int FollowingCount { get; set; }
        public bool IsOnline { get; set; }
        public string? ConnectTime { get; set; }
        public DateTime DisconnectTime { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? BackUpEmail { get; set; }
        public string? Occupation { get; set; }
        public string? Gender { get; set; }
        public string? RelationStatus { get; set; }
        public string? BloodGroup { get; set; }
        public string? Language { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }

        public virtual ICollection<Friendship>? Friendships { get; set; }
        public virtual ICollection<Post>? Posts { get; set; }
        public virtual ICollection<FriendRequest>? FriendRequests { get; set; }
        public virtual ICollection<Chat>? Chats { get; set; }

        public CustomIdentityUser()
        {
            Friendships = new List<Friendship>();
            FriendRequests = new List<FriendRequest>();
            Chats = new List<Chat>();
            Posts = new List<Post>();
        }



    }
}