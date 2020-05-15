using System;
using System.Collections.Generic;
using System.Text;
using DevPrep.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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
                    Id = 1,
                    Name = "HTML"
                },
                new SoftwareLanguage()
                {
                    Id = 2,
                    Name = "CSS"
                },
                new SoftwareLanguage()
                {
                    Id = 3,
                    Name = "Javascript"
                }, new SoftwareLanguage()
                {
                    Id = 4,
                    Name = "React"
                }, new SoftwareLanguage()
                {
                    Id = 5,
                    Name = "Github"
                }, new SoftwareLanguage()
                {
                    Id = 6,
                    Name = "Slack"
                }, new SoftwareLanguage()
                {
                    Id = 7,
                    Name = "Csharp"
                }, new SoftwareLanguage()
                {
                    Id = 8,
                    Name = "SQL"
                }, new SoftwareLanguage()
                {
                    Id = 9,
                    Name = "General Concepts"
                },
                new SoftwareLanguage()
                {
                    Id = 10,
                    Name = "DotNet"
                },
                new SoftwareLanguage()
                {
                    Id = 11,
                    Name = "Bootstrap"
                }
            );

            // Create two students
            modelBuilder.Entity<Concept>().HasData(
                new Concept()
                {
                    Id = 1,
                    Name = "Map",
                    SoftwareLanguageId = 3,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 2,
                    Name = "If/else",
                    SoftwareLanguageId = 3,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 3,
                    Name = "Anchor tags",
                    SoftwareLanguageId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 4,
                    Name = "CRUD",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 5,
                    Name = "Front End Developer",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 6,
                    Name = "Back End Developer",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 7,
                    Name = "Entity Relationship Diagram",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 8,
                    Name = "Javascript Object Notation",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 9,
                    Name = "User interface design",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Concept()
                {
                    Id = 10,
                    Name = "User experience design",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                }
                );
            modelBuilder.Entity<Description>().HasData(
            new Description()
            {
                Id = 1,
                Paragraph = "Alows you to go through each object and get the data on it",
                ConceptId = 1,
                ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
            },
                new Description()
                {
                    Id = 2,
                    Paragraph = "This is really helpful to use",
                    ConceptId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 3,
                    Paragraph = "This tells the computer to try the statement after the if in () and if that's true run the {} if it's false then run the else {}",
                    ConceptId = 2,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 4,
                    Paragraph = "Create, Read, Update, Delete are the four basic actions of persistent storage.",
                    ConceptId = 4,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 5,
                    Paragraph = "client side production (using HTML, CSS, JavaScript) for a Website/ Web Application so that a user can see and interact with it directly.",
                    ConceptId = 5,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 6,
                    Paragraph = " developing software on the server-side.  These are behind the scenes activities that happen when performing any action on a website.  Back-End Focuses on dealing with Databases. A Back End developer works with Database and cache, Servers, and APIs.",
                    ConceptId = 6,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 7,
                    Paragraph = "ERDs- shows tables in a database and the relationships between tables within that database. Entities are the things for which we want to store information",
                    ConceptId = 7,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 8,
                    Paragraph = "JSON- A standard file format that uses human readable text to store and transfer data objects consisting of key-value pairs and array data types.",
                    ConceptId = 8,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 9,
                    Paragraph = " It is easy for humans to read and write, it is easy for machines to parse and generate.",
                    ConceptId = 8,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 10,
                    Paragraph = "UI-This is strictly a digital term that talking about how a user interacts with the software.  UI considers the look, feel, and interactivity of the product.",
                    ConceptId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
<<<<<<< HEAD
                },
=======
                }, 
>>>>>>> master
                new Description()
                {
                    Id = 11,
                    Paragraph = "The goal is to make sure that the interface is as intuitive as possible. UI designers think about icons/buttons, typography and color schemes(graphic design), spacing, imagery, and responsive design.",
                    ConceptId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 12,
                    Paragraph = "UX Design. A human-first way of designing a software product. User experience include all aspects of the end-user’s interaction with the company, its services, and its products.",
                    ConceptId = 10,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                new Description()
                {
                    Id = 13,
                    Paragraph = "A designer should think about how the experience of using the software makes the user feel, and how easily they can accomplish their desired tasks.They try to improve the quality of interaction between the user and all facets of a company.",
                    ConceptId = 10,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                }

                );
            modelBuilder.Entity<UsefulLink>().HasData(
                new UsefulLink()
                {
                    Id = 1,
                    Title = "Here is a great youtube that explains maping",
                    Link = "www.youtube.com",
                    ConceptId = 1,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    InterviewQuestionId = null
                },
                 new UsefulLink()
                 {
                     Id = 2,
                     Title = "I love this article on mapping",
                     Link = "www.wsj.com",
                     ConceptId = 1,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 },
                 new UsefulLink()
                 {
                     Id = 3,
                     Title = "Watch this youtube to review how to do an if/esle",
                     Link = "www.youtube.com",
                     ConceptId = 2,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 },
                 new UsefulLink()
                 {
                     Id = 4,
                     Title = "Here is an enthusiastic YouTube explaining the difference between Back-End and Front End:",
                     Link = "https://www.youtube.com/watch?v=n_gODKYn9dM",
                     ConceptId = 6,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 },
                 new UsefulLink()
                 {
                     Id = 5,
                     Title = "Here is a great article about the difference between a front-end and a back-end developer:",
                     Link = "https://blog.udacity.com/2014/12/front-end-vs-back-end-vs-full-stack-web-developers.html",
                     ConceptId = 6,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 },
                 new UsefulLink()
                 {
                     Id = 6,
                     Title = "Here is a link to a website that will help you make your own ERD:",
                     Link = "https://dbdiagram.io/home",
                     ConceptId = 7,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 },
                 new UsefulLink()
                 {
                     Id = 7,
                     Title = "Here is a great book to pick up regarding this subject:",
                     Link = "https://en.wikipedia.org/wiki/Don%27t_Make_Me_Think",
                     ConceptId = 9,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     InterviewQuestionId = null
                 }
    );
            modelBuilder.Entity<VocabWord>().HasData(
             new VocabWord()
             {
                 Id = 1,
                 Word = "ERD",
                 Definition = "Entity Relationship Diagram- shows tables in a database and the relationships between tables within that database",
                 SoftwareLanguageId = 9,
                 ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
             },
              new VocabWord()
              {
                  Id = 2,
                  Word = "JSON",
                  Definition = "Javascript Object Notation. A standard file format that uses human readable text to store and transfer data objects consisting of key-value pairs and array data types.",
                  SoftwareLanguageId = 9,
                  ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
              },
                new VocabWord()
                {
                    Id = 3,
                    Word = "Front End Developer",
                    Definition = "client side production of Websites and Apps so that a user can see and interact directly",
                    SoftwareLanguageId = 9,
                    ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                },
                 new VocabWord()
                 {
                     Id = 4,
                     Word = "C.S.S.",
                     Definition = "Cascading Style Sheets",
                     SoftwareLanguageId = 2,
                     ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                 }
);




        }
    }
}