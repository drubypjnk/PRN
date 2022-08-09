using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Account
    {
        public Account()
        {
            Comments = new HashSet<Comment>();
            Notes = new HashSet<Note>();
            Notifies = new HashSet<Notify>();
            Orders = new HashSet<Order>();
        }
       
        public Account(string username, string name, string address, string mobile, DateTime? dob, string avartar, string email, string city)
        {
            Username = username;
            Name = name;
            Address = address;
            Mobile = mobile;
            Dob = dob;
            Avartar = avartar;
            Email = email;
            City = city;
            Comments = new HashSet<Comment>();
            Notifies = new HashSet<Notify>();
            Orders = new HashSet<Order>();
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public DateTime? Dob { get; set; }
        public string Avartar { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Notify> Notifies { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
