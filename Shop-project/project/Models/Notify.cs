using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Notify
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Backlink { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual Account UsernameNavigation { get; set; }
    }
}
