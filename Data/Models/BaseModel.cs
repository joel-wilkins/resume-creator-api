using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ResumeCreatorApi.Data.Models
{
    public class BaseModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [Column("created")]
        public DateTimeOffset Created { get; set; }

        [Required]
        [Column("updated")]
        public DateTimeOffset Updated { get; set; }

        [Required]
        [Column("deleted")]
        public bool Deleted { get; set; }

        public static void Configure<T>(ModelBuilder builder, Action<EntityTypeBuilder<T>> modelConfiguration = null) where T : BaseModel
        {
            builder.Entity<T>(uph =>
            {
                uph.Property(uph => uph.Created).HasDefaultValueSql("now() at time zone 'utc'");
                uph.Property(uph => uph.Updated).HasDefaultValueSql("now() at time zone 'utc'");
                uph.Property(uph => uph.Deleted).HasDefaultValue(false);
                if (modelConfiguration != null)
                {
                    modelConfiguration(uph);
                }
            });
        }
    }
}