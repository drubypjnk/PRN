using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime? Date { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }

        public virtual Order Order { get; set; }
        public virtual Account UsernameNavigation { get; set; }

        public Note(int? orderId, DateTime? date, string content, string username)
        {
            OrderId = orderId;
            Date = date;
            Content = content;
            Username = username;
        }
    }
}
