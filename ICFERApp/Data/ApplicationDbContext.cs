using System;
using System.Collections.Generic;
using System.Text;
using ICFERApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ICFERApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Guardian> Guardian { get; set; }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<Siblings> Siblings { get; set; }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>()
                .HasOne(e => e.Education)
                .WithOne(s => s.Student);


            builder.Entity<Student>()
                .HasOne(g => g.Guardian)
                .WithOne(s => s.Student);

            builder.Entity<Student>()
                .HasOne(p => p.Parents)
                .WithOne(s => s.Student);

            builder.Entity<Student>()
                .HasOne(s => s.Siblings)
                .WithOne(s => s.Student);
            

            builder.Entity<Education>()
                .HasOne(s => s.Student)
                .WithOne(e => e.Education);
            builder.Entity<Guardian>()
                .HasOne(s => s.Student)
                .WithOne(g => g.Guardian);
            
            builder.Entity<Parents>()
                .HasOne(s => s.Student)
                .WithOne(p => p.Parents);
            
            builder.Entity<Siblings>()
                .HasOne(s => s.Student)
                .WithOne(p => p.Siblings);
        }
    }
}