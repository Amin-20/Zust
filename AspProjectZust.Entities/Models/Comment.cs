﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Core.Abstraction;

namespace Zust.Entities.Models
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int LikeCount { get; set; }
        public DateTime WriteTime { get; set; }
        public int CustomIdentityUserId { get; set; }
        public virtual Post? Post { get; set; }
        public virtual CustomIdentityUser? User { get; set; }
    }
}
