using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffTracker.Models
{
    public class UserLog
    {
        [Key]
        public Guid UserLogID { get; set; }

        public DateTime DateTimeStamp { get; set; }
        public string UserId { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

    }

}