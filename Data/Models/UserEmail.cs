using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("user_email")]
    public class UserEmail : BaseModel
    {
        [Required]
        [MaxLength(320)]
        [Column("email_address")]
        public string EmailAddress { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<UserEmail>(builder, ue =>
            {
                ue.HasIndex(ue => ue.UserId);
            });
        }
    }
}