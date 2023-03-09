using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class Context:IdentityDbContext<ApplicationUser>
    {

        public Context() { }

        //inJection

        public Context(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CvTemplate> CvTemplates { get; set; }
        public DbSet<UserData> UserData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MAHMOUD-EMAD\\SQL19;Initial Catalog=CvBuilder;Integrated Security=True;Encrypt=False");
        }
    }
}
