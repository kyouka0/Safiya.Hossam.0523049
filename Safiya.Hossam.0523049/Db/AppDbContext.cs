using Microsoft.EntityFrameworkCore;
using Safiya.Hossam._0523049.Models;

namespace Safiya.Hossam._0523049.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions op) : base(op) { }



        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<Competition> competitions { get; set; }
        public DbSet<Player> players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>().HasOne(x => x.Team).WithOne(x => x.Coach).HasForeignKey<Team>(x => x.CoachId);

            modelBuilder.Entity<Team>().HasMany(x => x.players).WithOne(x => x.Team);
            modelBuilder.Entity<Team>().HasMany(x => x.competitions).WithMany(x => x.teams);

            modelBuilder.Entity<Coach>().HasData(

                new Coach { Id = 1, Name = "Safiya", Specilazation = "FootBall", ExperienceYears = 5 },
                                new Coach { Id = 2, Name = "mana", Specilazation = "kasbd", ExperienceYears = 3 },
                new Coach { Id = 3, Name = "Sara", Specilazation = "poiq", ExperienceYears = 2 }

                );
            modelBuilder.Entity<Team>().HasData(

                 new Team { Id = 1, Ciy = "Giza", Name = "MRT", CoachId = 1 },
                new Team { Id = 2, Ciy = "Warraq", Name = "SEQ", CoachId = 2 },
                 new Team { Id = 3, Ciy = "Giza", Name = "CRT", CoachId = 3 }

                 );
            modelBuilder.Entity<Competition>().HasData(
                 new Competition { Id = 1, Name = "Isef", Location = "TRRVS", Date = DateOnly.Parse("2008-09-11") },

               new Competition { Id = 2, Name = "ProbSolve", Location = "AXD", Date = DateOnly.Parse("2022-09-21") },
                 new Competition { Id = 3, Name = "Isef", Location = "TRRVS", Date = DateOnly.Parse("2025-08-10") }
                 );

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, FullName = "NourMohamed", Position = "La3epMarma", Age = 18, TeamId = 1 },

               new Player { Id = 2, FullName = "OmarAhmed", Position = "Attacker", Age = 17, TeamId = 2 },
                new Player { Id = 3, FullName = "MazenYousef", Position = "Modafe3", Age = 18, TeamId = 3 });


        }
    }
}
