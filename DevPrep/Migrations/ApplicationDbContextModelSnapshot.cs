﻿// <auto-generated />
using System;
using DevPrep.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevPrep.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevPrep.Models.Concept", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoftwareLanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("SoftwareLanguageId");

                    b.ToTable("Concepts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "Map",
                            SoftwareLanguageId = 3
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "If/else",
                            SoftwareLanguageId = 3
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "Anchor tags",
                            SoftwareLanguageId = 1
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "CRUD",
                            SoftwareLanguageId = 9
                        },
                        new
                        {
                            Id = 5,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "Front End Developer",
                            SoftwareLanguageId = 9
                        },
                        new
                        {
                            Id = 6,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "Back End Developer",
                            SoftwareLanguageId = 9
                        },
                        new
                        {
                            Id = 7,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "Entity Relationship Diagram",
                            SoftwareLanguageId = 9
                        },
                        new
                        {
                            Id = 8,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "Javascript Object Notation",
                            SoftwareLanguageId = 9
                        },
                        new
                        {
                            Id = 9,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "User interface design",
                            SoftwareLanguageId = 9
                        },
                        new
                        {
                            Id = 10,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Name = "User experience design",
                            SoftwareLanguageId = 9
                        });
                });

            modelBuilder.Entity("DevPrep.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ConceptId")
                        .HasColumnType("int");

                    b.Property<string>("Paragraph")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ConceptId");

                    b.ToTable("Descriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 1,
                            Paragraph = "Alows you to go through each object and get the data on it"
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 1,
                            Paragraph = "This is really helpful to use"
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 2,
                            Paragraph = "This tells the computer to try the statement after the if in () and if that's true run the {} if it's false then run the else {}"
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 4,
                            Paragraph = "Create, Read, Update, Delete are the four basic actions of persistent storage."
                        },
                        new
                        {
                            Id = 5,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 5,
                            Paragraph = "client side production (using HTML, CSS, JavaScript) for a Website/ Web Application so that a user can see and interact with it directly."
                        },
                        new
                        {
                            Id = 6,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 6,
                            Paragraph = " developing software on the server-side.  These are behind the scenes activities that happen when performing any action on a website.  Back-End Focuses on dealing with Databases. A Back End developer works with Database and cache, Servers, and APIs."
                        },
                        new
                        {
                            Id = 7,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 7,
                            Paragraph = "ERDs- shows tables in a database and the relationships between tables within that database. Entities are the things for which we want to store information"
                        },
                        new
                        {
                            Id = 8,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 8,
                            Paragraph = "JSON- A standard file format that uses human readable text to store and transfer data objects consisting of key-value pairs and array data types."
                        },
                        new
                        {
                            Id = 9,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 8,
                            Paragraph = " It is easy for humans to read and write, it is easy for machines to parse and generate."
                        },
                        new
                        {
                            Id = 10,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 9,
                            Paragraph = "UI-This is strictly a digital term that talking about how a user interacts with the software.  UI considers the look, feel, and interactivity of the product."
                        },
                        new
                        {
                            Id = 11,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 9,
                            Paragraph = "The goal is to make sure that the interface is as intuitive as possible. UI designers think about icons/buttons, typography and color schemes(graphic design), spacing, imagery, and responsive design."
                        },
                        new
                        {
                            Id = 12,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 10,
                            Paragraph = "UX Design. A human-first way of designing a software product. User experience include all aspects of the end-user’s interaction with the company, its services, and its products."
                        },
                        new
                        {
                            Id = 13,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 10,
                            Paragraph = "A designer should think about how the experience of using the software makes the user feel, and how easily they can accomplish their desired tasks.They try to improve the quality of interaction between the user and all facets of a company."
                        });
                });

            modelBuilder.Entity("DevPrep.Models.InterviewQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("InterviewQuestions");
                });

            modelBuilder.Entity("DevPrep.Models.SoftwareLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SoftwareLanguages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HTML"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CSS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Javascript"
                        },
                        new
                        {
                            Id = 4,
                            Name = "React"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Github"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Slack"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Csharp"
                        },
                        new
                        {
                            Id = 8,
                            Name = "SQL"
                        },
                        new
                        {
                            Id = 9,
                            Name = "General Concepts"
                        },
                        new
                        {
                            Id = 10,
                            Name = "DotNet"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Bootstrap"
                        });
                });

            modelBuilder.Entity("DevPrep.Models.UsefulLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ConceptId")
                        .HasColumnType("int");

                    b.Property<int?>("InterviewQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ConceptId");

                    b.HasIndex("InterviewQuestionId");

                    b.ToTable("UsefulLinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 1,
                            Link = "www.youtube.com",
                            Title = "Here is a great youtube that explains maping"
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 1,
                            Link = "www.wsj.com",
                            Title = "I love this article on mapping"
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 2,
                            Link = "www.youtube.com",
                            Title = "Watch this youtube to review how to do an if/esle"
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 6,
                            Link = "https://www.youtube.com/watch?v=n_gODKYn9dM",
                            Title = "Here is an enthusiastic YouTube explaining the difference between Back-End and Front End:"
                        },
                        new
                        {
                            Id = 5,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 6,
                            Link = "https://blog.udacity.com/2014/12/front-end-vs-back-end-vs-full-stack-web-developers.html",
                            Title = "Here is a great article about the difference between a front-end and a back-end developer:"
                        },
                        new
                        {
                            Id = 6,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 7,
                            Link = "https://dbdiagram.io/home",
                            Title = "Here is a link to a website that will help you make your own ERD:"
                        },
                        new
                        {
                            Id = 7,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            ConceptId = 9,
                            Link = "https://en.wikipedia.org/wiki/Don%27t_Make_Me_Think",
                            Title = "Here is a great book to pick up regarding this subject:"
                        });
                });

            modelBuilder.Entity("DevPrep.Models.VocabWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Definition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoftwareLanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("SoftwareLanguageId");

                    b.ToTable("VocabWords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Definition = "Entity Relationship Diagram- shows tables in a database and the relationships between tables within that database",
                            SoftwareLanguageId = 9,
                            Word = "ERD"
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Definition = "Javascript Object Notation. A standard file format that uses human readable text to store and transfer data objects consisting of key-value pairs and array data types.",
                            SoftwareLanguageId = 9,
                            Word = "JSON"
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Definition = "client side production of Websites and Apps so that a user can see and interact directly",
                            SoftwareLanguageId = 9,
                            Word = "Front End Developer"
                        },
                        new
                        {
                            Id = 4,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            Definition = "Cascading Style Sheets",
                            SoftwareLanguageId = 2,
                            Word = "C.S.S."
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DevPrep.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac42a5e9-970a-4c69-b2fd-9b4791628bb1",
                            Email = "rebs@rebs.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "REBS@REBS.COM",
                            NormalizedUserName = "REBS@REBS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO7OvC42tK/FjuaKY4mg41q5WIgN1LrTbFSI5j6NrfPkOPVlVhB85g44Kc6CSEK1uw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "rebs@rebs.com",
                            FirstName = "Rebecca",
                            LastName = "Patek"
                        });
                });

            modelBuilder.Entity("DevPrep.Models.Concept", b =>
                {
                    b.HasOne("DevPrep.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DevPrep.Models.SoftwareLanguage", "SoftwareLanguage")
                        .WithMany("Concepts")
                        .HasForeignKey("SoftwareLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DevPrep.Models.Description", b =>
                {
                    b.HasOne("DevPrep.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DevPrep.Models.Concept", "Concept")
                        .WithMany("Descriptions")
                        .HasForeignKey("ConceptId");
                });

            modelBuilder.Entity("DevPrep.Models.InterviewQuestion", b =>
                {
                    b.HasOne("DevPrep.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("DevPrep.Models.UsefulLink", b =>
                {
                    b.HasOne("DevPrep.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DevPrep.Models.Concept", "Concept")
                        .WithMany("UsefulLinks")
                        .HasForeignKey("ConceptId");

                    b.HasOne("DevPrep.Models.InterviewQuestion", "InterviewQuestion")
                        .WithMany()
                        .HasForeignKey("InterviewQuestionId");
                });

            modelBuilder.Entity("DevPrep.Models.VocabWord", b =>
                {
                    b.HasOne("DevPrep.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DevPrep.Models.SoftwareLanguage", "SoftwareLanguage")
                        .WithMany()
                        .HasForeignKey("SoftwareLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
