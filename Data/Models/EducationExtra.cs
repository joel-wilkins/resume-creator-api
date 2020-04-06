using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("education_extra")]
    public class EducationExtra : BaseModel
    {
        [Required]
        [MaxLength(250)]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [Column("education_id")]
        public Guid EducationId { get; set; }

        public Education Education { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<EducationExtra>(builder, ee =>
            {
                ee.HasIndex(ee => ee.EducationId);
            });
        }
    }
}