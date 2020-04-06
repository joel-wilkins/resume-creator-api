using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("resume")]
    public class Resume : BaseModel
    {
        [Required]
        [Column("career")]
        public string Career { get; set; }

        [Required]
        [Column("experience_in_years")]
        public int ExperienceInYears { get; set; }

        [Required]
        [Column("display_phone_number_id")]
        public Guid DisplayPhoneNumberId { get; set; }

        [Required]
        [Column("display_email_id")]
        public Guid DisplayEmailId { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Required]
        [Column("bio_id")]
        public Guid BioId { get; set; }

        public Bio Bio { get; set; }

        [ForeignKey("DisplayEmailId")]
        public UserEmail UserEmail { get; set; }

        [ForeignKey("DisplayPhoneNumberId")]
        public UserPhoneNumber UserPhoneNumber { get; set; }

        public User User { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<Resume>(builder, r =>
            {
                r.HasIndex(r => r.BioId);
                r.HasIndex(r => r.DisplayEmailId);
                r.HasIndex(r => r.DisplayPhoneNumberId);
                r.HasIndex(r => r.UserId);
            });
        }
    }
}