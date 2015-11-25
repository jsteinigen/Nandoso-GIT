using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nandoso.Models
{
    //public enum Gender
//    {
//        M, F 
//    }

    //    public enum UserGroup
    //    {
    //        G, E
    //    }

    public class User
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string UserGroup { get; set; } 

        //[JsonIgnore]
        //public virtual ICollection<Order> Orders { get; set; }

    }
}
