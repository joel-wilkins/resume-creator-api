using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("bio")]
    public class Bio : BaseModel
    {
        [Column("photo_url")]
        public Uri PhotoUrl { get; set; }

        [Required]
        [MaxLength(400)]
        [Column("biography")]
        public string Biography { get; set; }

        public Resume Resume { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<Bio>(builder);
        }
    }
}