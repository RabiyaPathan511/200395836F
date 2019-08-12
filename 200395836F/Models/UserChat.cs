using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395836F.Models
{
    public class UserChat
    {
        //primary key user id
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }  //name of the user
        [Required]
        public string Message { get; set; }//message of the user
        [Required]
        public DateTime CreatedAt { get; set; }//date and time of created message
    }
}