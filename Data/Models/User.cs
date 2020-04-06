using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("user")]
    public class User : BaseModel
    {
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; }

        public List<Resume> Resumes { get; set; }

        public List<UserPhoneNumber> PhoneNumbers { get; set; }

        public List<UserEmail> Emails { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<User>(builder);
        }
    }
}