using System;
using System.Collections.Generic;
using System.Text;
using ASPDotNetCoreProject_Moin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreProject_Moin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; } 
        public DbSet<BooksInfo> BooksInfos { get; set; }  
        public DbSet<SpecialCourse> Courses { get; set; }   
        public DbSet<Trainee> Trainees { get; set; }    
        public DbSet<BookCategory> BookCategories { get; set; }    
        public DbSet<Books> Books { get; set; }     

    }
}
