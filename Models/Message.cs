﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual User? User { get; set; }
    }

}
