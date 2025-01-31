using Microsoft.EntityFrameworkCore;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(s => s.Student)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(s => s.Course)
                .WithMany( c => c.StudentCourses)
                .HasForeignKey(s => s.CourseId);

            // One To many
            //modelBuilder.Entity<Product>()
            //    .HasOne(c => c.Category)
            //    .WithMany(c => c.Products)
            //    .HasForeignKey(c => c.CategoryId);
        }
    }
}
