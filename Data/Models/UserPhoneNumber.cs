using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("user_phone_number")]
    public class UserPhoneNumber : BaseModel
    {
        [Column("country_code")]
        public int CountryCode { get; set; }

        [Required]
        [Column("area_code")]
        public int AreaCode { get; set; }

        [Required]
        [Column("phone_number")]
        public int PhoneNumber { get; set; }

        [Column("extension")]
        public int Extension { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<UserPhoneNumber>(builder, uph =>
            {
                uph.HasIndex(uph => uph.UserId);
            });
        }
    }
}