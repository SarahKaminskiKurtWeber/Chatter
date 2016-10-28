using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Chat
    {
        [Key]
        public int ChatID { get; set; }
        public string ChatText { get; set; }
        public string ChatUserName { get; set; }

        //[ForeignKey("IdentityUser")]
        //public int IdentityUserID { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }        
    }
}