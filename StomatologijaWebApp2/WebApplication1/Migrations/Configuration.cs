using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;
using WebApplication1.Enumerations;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            SeedRoles(context);
            SeedAll(context);

            #region commentedOut
            //var passwordHasher = new PasswordHasher();
            //context.Users.AddOrUpdate(
            //    new Dentist
            //    {
            //        FirstName = "Prvi",
            //        LastName = "Doktor",
            //        PasswordHash = passwordHasher.HashPassword("polamarke"),
            //        DateOfBirth = new DateTime(1977, 4, 3),
            //        EmploymentStatus = EmploymentStatus.Employed,
            //        PhoneNumber = "062/062-062",
            //        Email = "prvi@gmail.com",
            //        Address = "Kulovica 9",
            //        DateCreated = DateTime.Now
            //    }
            //    );


            ////Seeding Dentist Class

            //var passwordHasher = new PasswordHasher();
            //context.Users.AddOrUpdate(
            //    new Dentist
            //    {
            //        FirstName = "Prvi",
            //        LastName = "Doktor",
            //        PasswordHash = passwordHasher.HashPassword("polamarke"),
            //        DateOfBirth = new DateTime(1977, 4, 3),
            //        EmploymentStatus = EmploymentStatus.Employed,
            //        PhoneNumber = "062/062-062",
            //        Email = "prvi@gmail.ocami",
            //        Address = "Kulovica 9",
            //        DateCreated = DateTime.Now


            //        //DateModified = new DateTime(2015, 5, 16, 13, 45, 0), This can be done later because I changed DateModified to be nullable, so it doesn't have to be populated now
            //        //Patients          needs to be implemented...? 
            //    }
            // );

            //    new Models.Dentist { 
            //        Id = 2,
            //        FirstName = "Druga",
            //        LastName = "Doktorka",
            //        Password = "dvijemarke",
            //        DateOfBirth = new DateTime(1973, 2, 3),
            //        EmploymentStatus = Models.EmploymentStatus.Employed,
            //        PhoneNumber = "062/061-061",
            //        Email = "drugi@gmail.ocami",
            //        Address = "Ramovica 9",
            //        DateCreated = DateTime.Now,
            //        //DateModified = new DateTime(2015, 5, 17, 13, 45, 0),
            //        //Patients         needs to be implemented...? 
            //    },

            //    new Models.Dentist {
            //        Id = 3,
            //        FirstName = "Treci",
            //        LastName = "Doka",
            //        Password = "trimarke",
            //        DateOfBirth = new DateTime(1985, 8, 3),
            //        EmploymentStatus = Models.EmploymentStatus.Student,
            //        PhoneNumber = "062/063-063", 
            //        Email = "treci@gmail.ocami",
            //        Address = "Muvedina 8",
            //        DateCreated = DateTime.Now 
            //        //DateModified = new DateTime(2015, 5, 17, 12, 45, 0),
            //        //Patients          needs to be implemented...? 
            //    }
            //);

            ////Seeding Patient Class
            //context.Patients.AddOrUpdate( 
            //   k => k.Id,
            //   new Models.Patient
            //   {
            //       Id = 1,
            //       FirstName = "Pacijent",
            //       LastName = "Bolesni",
            //       Password = "fening",
            //       DateOfBirth = new DateTime(1987, 4, 3),
            //       Address = "Brcanska 2", 
            //       DateCreated = DateTime.Now,
            //       EmploymentStatus = Models.EmploymentStatus.Employed,
            //       //DateModified = new DateTime(2015, 5, 19, 13, 45, 0),
            //       Email = "cetvrti@gmail.ocami",
            //       PhoneNumber = "062/064-064",
            //       DentistId = 2,
            //       // Dentist =             needs to be implemented...? 
            //       // EmploymentStatus =    needs to be implemented...? 
            //       // MedicalRecords =      needs to be implemented...? 
            //   },

            //   new Models.Patient
            //   {
            //       Id = 2,
            //       FirstName = "Drugi",
            //       LastName = "Bolesnik",
            //       Password = "dolar",
            //       DateOfBirth = new DateTime(1957, 4, 3),
            //       Address = "Malta 2",
            //       DateCreated = DateTime.Now,
            //       EmploymentStatus = Models.EmploymentStatus.Retired,
            //       //DateModified = new DateTime(2015, 5, 19, 13, 45, 0),
            //       Email = "cetvrti@gmail.ocami",
            //       PhoneNumber = "062/065-065",
            //       DentistId = 1,
            //       // Dentist =             needs to be implemented...? 
            //       // EmploymentStatus =    needs to be implemented...? 
            //       // MedicalRecords =      needs to be implemented...? 
            //   },

            //   new Models.Patient
            //   {
            //       Id = 3,
            //       FirstName = "Pacijentac",
            //       LastName = "Najbolesniji",
            //       Password = "feningas",
            //       DateOfBirth = new DateTime(1993, 4, 3),
            //       Address = "Logavina 2",
            //       DateCreated = DateTime.Now,
            //       EmploymentStatus = Models.EmploymentStatus.Student,
            //       //DateModified = new DateTime(2015, 5, 12, 13, 45, 0),
            //       Email = "peti@gmail.ocami",
            //       PhoneNumber = "062/066-066",
            //       DentistId = 2,

            //       // Dentist =             needs to be implemented...? 
            //       // EmploymentStatus =    needs to be implemented...? 
            //       // MedicalRecords =      needs to be implemented...? 
            //   }
            //);

            ////Seeding MedicalRecords Class
            //context.MedicalRecords.AddOrUpdate( 
            //   x => x.Id,
            //   new Models.MedicalRecord
            //   {
            //       Id = 1,
            //       Description = "ovo je neki deskrip�n",
            //       DateCreated = DateTime.Now,
            //       //DateModified = new DateTime(2015, 5, 16, 13, 45, 0),
            //       Bill =  144.5,
            //       PatientId = 3 
            //       // EmploymentStatus =        needs to be implemented...? 
            //       // MedicalRecords =          needs to be implemented...? 
            //    },

            //   new Models.MedicalRecord
            //   {
            //       Id = 2,
            //       Description = "ovo je neki drugi deskrip�n",
            //       DateCreated = DateTime.Now,
            //       //DateModified = new DateTime(2015, 5, 16, 2, 45, 0),
            //       Bill = 34.2, 
            //       PatientId = 2
            //       // Dentist =                 needs to be implemented...? 
            //       // EmploymentStatus =        needs to be implemented...? 
            //       // MedicalRecords =          needs to be implemented...? 
            //    },

            //   new Models.MedicalRecord
            //   {
            //       Id = 3,
            //       Description = "ovo je neki zadnji treci deskrip�n",
            //       DateCreated = DateTime.Now,
            //       //DateModified = new DateTime(2015, 5, 17, 19, 45, 0),
            //       Bill = 554.5,
            //       PatientId = 2
            //       // Dentist =                 needs to be implemented...? 
            //       // EmploymentStatus =        needs to be implemented...? 
            //       // MedicalRecords =          needs to be implemented...? 
            //   }
            //); 
            #endregion
            
        }

        //Seeding everything except Identity tables (Roles, Logins and Claims)
        private void SeedAll(ApplicationDbContext context)
        {
            var passwordHasher = new PasswordHasher();

            var downLeft = new Tooth
            {
                ToothPosition = ToothPosition.dl3,
                ToothState = ToothState.NoTooth
            };

            var upLeft = new Tooth
            {
                ToothPosition = ToothPosition.gl6,
                ToothState = ToothState.Caries1
            };

            var medicalRecord = new MedicalRecord
            {
                DateCreated = DateTime.Now,
                Description = "Vadjena sestica gornja lijeva",
                Teeth = new List<Tooth>() { downLeft }
            };
            var medicalRecord2 = new MedicalRecord
            {
                DateCreated = DateTime.Now,
                Description = "Radjena krunica donje lijeve trice",
                Teeth = new List<Tooth>() { upLeft}
            };
            var patient = new Patient
            {

                UserName = "omeraga",
                PasswordHash = passwordHasher.HashPassword("P@ssw0rd"),
                FirstName = "Omer",
                LastName = "Ahmetagic",
                DateOfBirth = new DateTime(1987, 4, 3),
                Address = "Brcanska 2",
                DateCreated = DateTime.Now,
                EmploymentStatus = EmploymentStatus.Student,
                Email = "omer.ahmetagic@gmail.ocami",
                PhoneNumber = "062/064-064",
                MedicalHistory = new MedicalHistory
                {
                    Note = "Patient's teeth are just awesome and he is ready to get married.",
                    MedicalRecords = new List<MedicalRecord>() { medicalRecord, medicalRecord2}
                }
            };

            var patient2 = new Patient
            {

                UserName = "jusufaga",
                PasswordHash = passwordHasher.HashPassword("P@ssw0rd"),
                FirstName = "Jusuf",
                LastName = "Koric",
                DateOfBirth = new DateTime(1993, 4, 3),
                Address = "Butmirska Neka 12",
                DateCreated = DateTime.Now,
                EmploymentStatus = EmploymentStatus.Student,
                Email = "jusufk12@gmail.com",
                PhoneNumber = "062/064-064",
                MedicalHistory = new MedicalHistory
                {
                    Note = "Patient's teeth are very good, but since he is awesome looking, he is ready to get married.",
                    MedicalRecords = new List<MedicalRecord>()
                }
            };

            var dentist = new Dentist
            {
                FirstName = "Emir",
                LastName = "Hodzic",
                UserName = "emiraga",
                PasswordHash = passwordHasher.HashPassword("P@ssw0rd"),
                DateOfBirth = new DateTime(1992, 3, 20),
                EmploymentStatus = EmploymentStatus.Employed,
                PhoneNumber = "+38762876923",
                Email = "emir.hodzich@gmail.com",
                Address = "Igmanskih Bataljona 27",
                Place = "Hrasnicka cesta 13",
                DateCreated = DateTime.Now,
                EmailConfirmed = true,
                Patients = new List<Patient>() { patient, patient2 }
            };
            context.Users.AddOrUpdate(dentist);
            context.Users.AddOrUpdate(patient);
            context.Users.AddOrUpdate(patient2);
            context.SaveChanges();
        }

        //Seeding Dentist Class
        private void SeedAllWithUserManager(ApplicationDbContext context)
        {
            var passwordHasher = new PasswordHasher();
            if (!context.Users.Any())
            {
                //Creation of all stores
                var dentistStore = new UserStore<Dentist>(context);
                var patientStore = new UserStore<Patient>(context);

                //Creation of Managers
                var patientManager = new UserManager<Patient>(patientStore);
                var dentistManager = new UserManager<Dentist>(dentistStore);

                var patient1 = new Patient
                {
                    UserName = "omeraga",
                    PasswordHash = passwordHasher.HashPassword("P@ssw0rd"),
                    FirstName = "Omer",
                    LastName = "Ahmetagic",
                    DateOfBirth = new DateTime(1987, 4, 3),
                    Address = "Brcanska 2",
                    DateCreated = DateTime.Now,
                    EmploymentStatus = EmploymentStatus.Student,
                    Email = "omer.ahmetagic@gmail.ocami",
                    PhoneNumber = "062/064-064",
                    
                  
                };
                patientManager.Create(patient1);

                var dentist1 = new Dentist
                {

                    FirstName = "Emir",
                    LastName = "Hodzic",
                    UserName = "emiraga",
                    PasswordHash = passwordHasher.HashPassword("P@ssw0rd"),
                    DateOfBirth = new DateTime(1992,3,20),
                    EmploymentStatus = EmploymentStatus.Employed,
                    PhoneNumber = "+38762876923",
                    Email = "emir.hodzich@gmail.com",
                    Address = "Kulovica 9",
                    DateCreated = DateTime.Now,
                    EmailConfirmed = true,
                    Patients = new List<Patient>() {patient1}

                };
                dentistManager.Create(dentist1);
                context.SaveChanges();

               
            }

        }

        //Seeding Role Class
        private void SeedRoles(ApplicationDbContext context)
        {
            if (!context.Roles.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userRole = new IdentityRole { Name = Role.User };
                roleManager.Create(userRole);

                var adminRole = new IdentityRole { Name = Role.Admin };
                roleManager.Create(adminRole);

                var dentistRole = new IdentityRole { Name = Role.Dentist };
                roleManager.Create(dentistRole);

                var patientRole = new IdentityRole { Name = Role.Patient };
                roleManager.Create(patientRole);

                context.SaveChanges();
            }
        }

        //Seeding Tooth Class 
        //
        //                       NEMOJTE GLEDATI OVE GLUPOSTI...NISAM VISE MOGAO DA RADIM
        //
        private void SeedTooth(ApplicationDbContext context)
        {
            if (!context.Roles.Any())
            {
                var tooth = new Tooth { ToothPosition = ToothPosition.gd1};
                var tooth2 = new Tooth { ToothPosition = ToothPosition.gl1};
                context.SaveChanges();
            }
        }

    }
}
