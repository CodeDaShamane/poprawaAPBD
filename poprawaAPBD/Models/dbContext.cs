using Microsoft.EntityFrameworkCore;
using System;

namespace poprawaAPBD.Models
{
    public class dbContext : DbContext
    {
        protected dbContext() { }
        public dbContext(DbContextOptions options) : base (options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}

        public DbSet<File> Files { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            
            //najpierw modele i DTO
            modelbuilder.Entity<File>(f =>
            {
                f.HasKey(f => f.FileID);
                f.Property(f => f.FileName).IsRequired().HasMaxLength(100);
                f.Property(f => f.FileExtention).IsRequired().HasMaxLength(4);
                f.Property(f => f.FileSize).IsRequired();
                //f.HasOne(f =>f.Team).WithMany(f => Files).HasForeignKey(f => f.TeamID);

                f.HasData(
                    new File {FileID =1, FileName="plik1",FileExtention="exe",FileSize =10},
                    new File {FileID =2, FileName="plik2",FileExtention="doc",FileSize =11},
                    new File {FileID =3, FileName="plik3",FileExtention="js",FileSize =15}
                    );
            });

            modelbuilder.Entity<Organization>(o =>
            {
                o.HasKey(o => o.OrganizationID);
                o.Property(o => o.OrganizationName).IsRequired().HasMaxLength(100);
                o.Property(o => o.OrganizationDomain).IsRequired().HasMaxLength(50);

                o.HasData(
                    new Organization { OrganizationID = 1, OrganizationName="fedex", OrganizationDomain="transport" },
                    new Organization { OrganizationID = 2, OrganizationName="topex", OrganizationDomain="sprzedaż" },
                    new Organization { OrganizationID = 3, OrganizationName="venturex", OrganizationDomain="internet" }
                    );

            });

            modelbuilder.Entity<Member>(m =>
            {
                m.HasKey(m => m.MebmerID);
                m.Property(m => m.MemberName).IsRequired().HasMaxLength(20);
                m.Property(m => m.MemberSurname).IsRequired().HasMaxLength(50);
                m.Property(m => m.MemberNickName).IsRequired().HasMaxLength(50);
                m.HasOne(m => m.Organization).WithMany(m=>Members).HasForeignKey(m=>m.OrganizationID);
                //f.HasKey(f => f.);

                m.HasData(
                    new Member {MebmerID =1, MemberName="adam", MemberSurname="kowalksk",MemberNickName ="Toma",OrganizationID = 1},
                    new Member {MebmerID =2, MemberName="fsmisn", MemberSurname="bob",MemberNickName ="Tomaszek",OrganizationID = 2},
                    new Member {MebmerID =3, MemberName="damian", MemberSurname="stopp",MemberNickName ="Tomasz",OrganizationID = 3}

                    );
            });

            modelbuilder.Entity<Team>(t =>
            {
                t.HasKey(t => t.TeamID);
                t.Property(t => t.TeamName).IsRequired().HasMaxLength(50);
                t.Property(t => t.TeamDescryption).HasMaxLength(500);
                t.HasOne(t => t.Organization).WithMany(t => Teams).HasForeignKey(t => t.OrganizationID);

                t.HasData(
                    new Team {TeamID =1,TeamName="A",TeamDescryption="abc",OrganizationID = 1 },
                    new Team {TeamID =2,TeamName="B",TeamDescryption="abce",OrganizationID = 2 },
                    new Team {TeamID =3,TeamName="C",TeamDescryption="abcefg",OrganizationID = 1 }
                    );
            });


            modelbuilder.Entity<Membership>(m =>
            {
                m.Property(m => m.MembershipDate).IsRequired();
                m.HasOne(m => m.Team).WithMany(m =>Memberships).HasForeignKey(m => m.TeamID);
                //f.HasKey(f => f.);

                m.HasData(
                    new Membership { MemberID =1, TeamID = 1, MembershipDate = DateTime.Parse("2022-03-21") },
                    new Membership { MemberID =2, TeamID = 2, MembershipDate = DateTime.Parse("2022-03-22") },
                    new Membership { MemberID =3, TeamID = 3, MembershipDate = DateTime.Parse("2022-03-23") }


                    );
            });



        }
    }
}
 