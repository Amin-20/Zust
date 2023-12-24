using AspProjectZust.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zust.Entities.Concrete
{
    public class Post
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public CustomIdentityUser user { get; set; }
        public List<IFormFile> images { get; set; }
        public List<IFormFile> videos { get; set; }
        public List<Friend> taggedFriends { get; set; }
        public string content { get; set; }
        public DateTime PublishTime { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
