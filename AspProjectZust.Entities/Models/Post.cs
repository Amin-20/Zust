using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Core.Abstraction;

namespace Zust.Entities.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public int CustomIdentityUserId { get; set; }
        public string? Images { get; set; }
        public string? Videos { get; set; }
        public string? Content { get; set; }
        public CustomIdentityUser? User { get; set; }
        public DateTime PublishTime { get; set; }
        public List<Friendship>? TaggedFriends { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
