﻿using Microsoft.EntityFrameworkCore;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
