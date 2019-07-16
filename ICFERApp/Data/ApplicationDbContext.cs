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
                .WithOne(s => s.Student)
                
                ;


            builder.Entity<Student>()
                .HasOne(g => g.Guardian)
                .WithOne(s => s.Student);

            builder.Entity<Student>()
                .HasOne(p => p.Parents)
                .WithOne(s => s.Student);

            builder.Entity<Student>()
                .HasOne(s => s.Siblings)
                .WithOne(s => s.Student);
            

            builder.Entity<Siblings>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Siblings>()
                .HasKey(x => new { x.Id, x.StudentId});

            builder.Entity<Education>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
            
            builder.Entity<Education>()
                .HasKey(x => new { x.Id, x.StudentId});


            builder.Entity<Guardian>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Guardian>()
                .HasKey(x => new { x.Id, x.StudentId});
            builder.Entity<Parents>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Parents>()
                .HasKey(x => new { x.Id, x.StudentId});
            
            

        }
    }
}