using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FTC.Data.Models
{
    public class UserDbEntity:IdentityUser
    {

        public  UserDbEntity()
        {
            IsDelete = false;
            CreateAt = DateTime.Now;
        }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime CreateAt { get; set; } 
        public DateTime UpdateAt { get; set; }
        public string FCMToken { get; set; }
        public bool IsDelete { get; set; }
    }
}
