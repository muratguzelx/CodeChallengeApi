
using Microsoft.EntityFrameAdessoCore;

namespace CodeChallengeApi.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupTeam> GroupTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Start Seeding Data
            #region Group
            modelBuilder.Entity<Group>()
             .HasData(new Group
             {
                 Id = 1,
                 Name = "A",
             });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id =2,
                    Name = "B",
                });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id = 3,
                    Name = "C",
                });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id = 4,
                    Name = "D",
                });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id = 5,
                    Name = "E",
                });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id = 6,
                    Name = "F",
                });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id = 7,
                    Name = "G",
                });

            modelBuilder.Entity<Group>()
                .HasData(new Group
                {
                    Id = 8,
                    Name = "H",
                });
            #endregion

            #region Country
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 1,
                   Name = "Türkiye",
               });

            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 2,
                   Name = "Almanya",
               });
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 3,
                   Name = "Fransa",
               });
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 4,
                   Name = "Hollanda",
               });
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 5,
                   Name = "Portekiz",
               });
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 6,
                   Name = "İtalya",
               });
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 7,
                   Name = "İspanya",
               });
            modelBuilder.Entity<Country>()
               .HasData(new Country
               {
                   Id = 8,
                   Name = "Belçika",
               });
            #endregion

            #region Team Turkey

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 1,
                    CountryId = 1,
                    Name = "Adesso İstanbul",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 2,
                    CountryId = 1,
                    Name = "Adesso Ankara",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 3,
                    CountryId = 1,
                    Name = "Adesso İzmir",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 4,
                    CountryId = 1,
                    Name = "Adesso Antalya",
                });

            #endregion

            #region Team Almanya

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 5,
                    CountryId = 2,
                    Name = "Adesso Berlin",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 6,
                    CountryId = 2,
                    Name = "Adesso Frankfurt",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 7,
                    CountryId = 2,
                    Name = "Adesso Münih",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 8,
                    CountryId = 2,
                    Name = "Adesso Dortmund",
                });

            #endregion

            #region Team Fransa
            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 9,
                    CountryId = 3,
                    Name = "Adesso Paris",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 10,
                    CountryId = 3,
                    Name = "Adesso Marsilya",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 11,
                    CountryId = 3,
                    Name = "Adesso Nice",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 12,
                    CountryId = 3,
                    Name = "Adesso Lyon",
                });
            #endregion

            #region Team Hollanda
            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 13,
                    CountryId = 4,
                    Name = "Adesso Amsterdam",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 14,
                    CountryId = 4,
                    Name = "Adesso Rotterdam",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 15,
                    CountryId = 4,
                    Name = "Adesso Lahey",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 16,
                    CountryId = 4,
                    Name = "Adesso Eindhoven",
                });
            #endregion

            #region Team Portekiz
            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 17,
                    CountryId = 5,
                    Name = "Adesso Lisbon",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 18,
                    CountryId = 5,
                    Name = "Adesso Porto",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 19,
                    CountryId = 5,
                    Name = "Adesso Braga",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 20,
                    CountryId = 5,
                    Name = "Adesso Coimbra",
                });
            #endregion

            #region Team İtalya
            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 21,
                    CountryId = 6,
                    Name = "Adesso Roma",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 22,
                    CountryId = 6,
                    Name = "Adesso Milano",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 23,
                    CountryId = 6,
                    Name = "Adesso Venedik",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 24,
                    CountryId = 6,
                    Name = "Adesso Napoli",
                });
            #endregion

            #region Team İspanya
            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 25,
                    CountryId = 7,
                    Name = "Adesso Sevilla",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 26,
                    CountryId = 7,
                    Name = "Adesso Madrid",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 27,
                    CountryId = 7,
                    Name = "Adesso Barselona",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 28,
                    CountryId = 7,
                    Name = "Adesso Granada",
                });
            #endregion

            #region Team Belçika
            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 29,
                    CountryId = 8,
                    Name = "Adesso Brüksel",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 30,
                    CountryId = 8,
                    Name = "Adesso Brugge",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 31,
                    CountryId = 8,
                    Name = "Adesso Gent",
                });

            modelBuilder.Entity<Team>()
                .HasData(new Team
                {
                    Id = 32,
                    CountryId = 8,
                    Name = "Adesso Anvers",
                });
            #endregion

            // End Seeding Data

            // Start Relationship
            #region Relationship
            modelBuilder.Entity<GroupTeam>()
                .HasKey(x => new { x.GroupId, x.TeamId });

            modelBuilder.Entity<GroupTeam>()
                .HasOne(x => x.Group)
                .WithMany(x => x.GroupTeams)
                .HasForeignKey(x => x.GroupId);

            modelBuilder.Entity<GroupTeam>()
                .HasOne(x => x.Team)
                .WithMany(x => x.GroupTeams)
                .HasForeignKey(x => x.TeamId);
            #endregion
            // End Relationship
        }
    }
}
