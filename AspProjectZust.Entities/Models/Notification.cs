using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Core.Abstraction;

namespace Zust.Entities.Models
{
    public class Notification : IEntity
    {
        public string? Id { get; set; }
        public string? SenderId { get; set; }
        public virtual CustomIdentityUser? Sender { get; set; }
        public string? ReceiverId { get; set; }
        public virtual CustomIdentityUser? Receiver { get; set; }
        public string? Content { get; set; }
        public bool IsCheck { get; set; } = false;
        public DateTime SentDate { get; set; }
    }
}
