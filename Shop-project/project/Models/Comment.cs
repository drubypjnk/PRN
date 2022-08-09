using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Username { get; set; }
        public DateTime? Date { get; set; }
        public string Content { get; set; }

        public virtual Product Product { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
