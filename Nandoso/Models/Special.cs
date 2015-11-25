using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nandoso.Models
{
    public class Special
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecialID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PicURL { get; set; }
        public Decimal Price { get; set; }

        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
