﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; } 
        public string? Name { get; set; }
         
        public string? Email { get; set; }

        public string? Password { get; set; }
        public string? PhoneNo{ get; set; }

        public string? Address { get; set; }

        public string? Role { get; set; }

        public string? Token {  get; set; }
    }
}
