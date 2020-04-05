using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data
{
    public class ResumeCreatorContext : DbContext
    {
        public ResumeCreatorContext([NotNull] DbContextOptions options) : base(options)
        {
        }
    }
}