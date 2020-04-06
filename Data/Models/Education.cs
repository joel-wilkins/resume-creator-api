using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("education")]
    public class Education : BaseModel
    {
        [Required]
        [MaxLength(125)]
        [Column("institution")]
        public string Institution { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("degree")]
        public string Degree { get; set; }

        [Column("grade_point_average")]
        public float GradePointAverage { get; set; }

        public List<EducationExtra> EducationExtras { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<Education>(builder);
        }
    }
}