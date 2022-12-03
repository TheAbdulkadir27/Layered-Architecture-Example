using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.Context
{
    public class DbDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\MSSQLSERVER01; Database=DbAgrıCulture; Integrated Security=true");
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<İmage> İmages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<about> aboutUs { get; set; }
    }
}
