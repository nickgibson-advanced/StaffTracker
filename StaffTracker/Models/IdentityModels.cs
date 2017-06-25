﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace StaffTracker.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public String FullName { get; set; }
        public String Mobile_No { get; set; }
        public String Medical_Conditions { get; set; }
        public String DBS_No { get; set; }
        public DateTime DBS_Clearance_Date { get; set; }
        public String Lifeguard_Qualification { get; set; }
        public DateTime Lifeguard_Qualification_Expiry_Date { get; set; }
        public String Teaching_Qualification { get; set; }
        public DateTime Teaching_Qualification_Date { get; set; }
        public String Address { get; set; }
        public Boolean AtWork { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<UserLog> UserLogs { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}