using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nandoso.Models
{
    public enum Status
    {
        ORDERED, COOKING, DELIVER, FULFILLED
    }

    public class Order
    {
        public int OrderID { get; set; }
        public int SpecialID { get; set; }
        public int UserID { get; set; }

        public Status? Status { get; set; }

        [JsonIgnore]
        public virtual Special Special { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
