using System;
using System.Collections.Generic;
using System.Text;
using DevPrep.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Concept> Concepts { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<InterviewQuestion> InterviewQuestions { get; set; }
        public DbSet<SoftwareLanguage> SoftwareLanguages { get; set; }
        public DbSet<UsefulLink> UsefulLinks { get; set; }
        public DbSet<VocabWord> VocabWords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Rebecca",
                LastName = "Patek",
                UserName = "rebs@rebs.com",
                NormalizedUserName = "REBS@REBS.COM",
                Email = "rebs@rebs.com",
                NormalizedEmail = "REBS@REBS.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Rebs1*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create two cohorts
            modelBuilder.Entity<SoftwareLanguage>().HasData(
                new SoftwareLanguage()
                {
                    id = 1,
                    Name = "HTML"
                },
                new SoftwareLanguage()
                {
                    id = 2,
                    Name = "CSS"
                },
                new SoftwareLanguage()
                {
                    id = 3,
                    Name = "Javascript"
                }, new SoftwareLanguage()
                {
                    id = 4,
                    Name = "React"
                }, new SoftwareLanguage()
                {
                    id = 5,
                    Name = "Github"
                }, new SoftwareLanguage()
                {
                    id = 6,
                    Name = "Slack"
                }, new SoftwareLanguage()
                {
                    id = 7,
                    Name = "Csharp"
                }, new SoftwareLanguage()
                {
                    id = 8,
                    Name = "SQL"
                }, new SoftwareLanguage()
                {
                    id = 9,
                    Name = "General Concepts"
                },
                new SoftwareLanguage()
                {
                    id = 10,
                    Name = "DotNet"
                },
                new SoftwareLanguage()
                {
                    id = 11,
                    Name = "Bootstrap"
                }
            );

            // Create two students
            modelBuilder.Entity<Concept>().HasData(
                new Concept()
                {
                    id = 1,
                    Name = "Map",
                    SoftwareLanguageId = 3,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    id = 2,
                    Name = "If/else",
                    SoftwareLanguageId = 3,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    id = 3,
                    Name = "Anchor tags",
                    SoftwareLanguageId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                }
                );
            modelBuilder.Entity<Description>().HasData(
            new Description()
            {
                id = 1,
                Paragraph = "Alows you to go through each object and get the data on it",
                ConceptId = 1,
                ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
            },
                new Description()
                {
                    id = 2,
                    Paragraph = "This is really helpful to use",
                    ConceptId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    id = 3,
                    Paragraph = "This tells the computer to try the statement after the if in () and if that's true run the {} if it's false then run the else {}",
                    ConceptId = 2,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                }
                );
            modelBuilder.Entity<UsefulLink>().HasData(
                new UsefulLink()
                {
                    id = 1,
                    Title = "Here is a great youtube that explains maping",
                    Link = "www.youtube.com",
                    ConceptId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    InterviewQuestionId = null
                },
                 new UsefulLink()
                 {
                     id = 2,
                     Title = "I love this article on mapping",
                     Link = "www.wsj.com",
                     ConceptId = 1,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 },
                 new UsefulLink()
                 {
                     id = 3,
                     Title = "Watch this youtube to review how to do an if/esle",
                     Link = "www.youtube.com",
                     ConceptId = 2,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 }
    );
            modelBuilder.Entity<VocabWord>().HasData(
             new VocabWord()
             {
                 id = 1,
                 Word = "Object",
                 Definition = "Something",
                 SoftwareLanguageId = 1,
                 ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
             },
              new VocabWord()
              {
                  id = 2,
                  Word = "Software",
                  Definition = "Ware that is Soft",
                  SoftwareLanguageId = 1,
                  ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
              },
                new VocabWord()
                {
                    id = 3,
                    Word = "Trick",
                    Definition = "way to get around something",
                    SoftwareLanguageId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                 new VocabWord()
                 {
                     id = 4,
                     Word = "C.S.S.",
                     Definition = "Cascading Style Sheets",
                     SoftwareLanguageId = 2,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                 }
);




        }
    }
}
