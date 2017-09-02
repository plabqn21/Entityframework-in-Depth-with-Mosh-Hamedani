using System.Data.Entity;

namespace EntityframeworkWithMosh
{
    class ApplicationDbContex : DbContext
    {


        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }






        public ApplicationDbContex()
            : base("name=ApplicationDbContext")
        {


        }

    }
}
