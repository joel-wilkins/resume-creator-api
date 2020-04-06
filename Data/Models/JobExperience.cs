using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("job_experience")]
    public class JobExperience : BaseModel
    {
        [Required]
        [MaxLength]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("job_id")]
        public Guid JobId { get; set; }

        public Job Job { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<JobExperience>(builder, j =>
            {
                j.HasIndex(j => j.JobId);
            });
        }
    }
}