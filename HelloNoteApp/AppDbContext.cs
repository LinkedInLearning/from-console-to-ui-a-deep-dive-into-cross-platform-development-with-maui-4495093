using System;
using Microsoft.EntityFrameworkCore;

namespace HelloNote.Shared
{
    public class AppDbContext : DbContext
    {

        public DbSet<Note> Notes { get; set; }

        public string DbPath { get; }

        public AppDbContext()
        {

            var folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "HelloNote");

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            DbPath = Path.Combine(folder, "notes.db");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}

