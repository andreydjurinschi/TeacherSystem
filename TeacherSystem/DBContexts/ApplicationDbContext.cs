using Microsoft.EntityFrameworkCore;

namespace TeacherSystem.DBContexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}