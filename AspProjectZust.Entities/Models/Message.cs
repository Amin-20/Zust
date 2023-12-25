﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Core.Abstraction;

namespace Zust.Entities.Models
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public bool IsImage { get; set; }
        public DateTime WriteTime { get; set; }
        public string? ReceiverId { get; set; }
        public string? SenderId { get; set; }
        public bool HasSeen { get; set; }
        public int ChatId { get; set; }
        public virtual Chat? Chat { get; set; }
    }
}
