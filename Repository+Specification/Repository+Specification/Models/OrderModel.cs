using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Specification.Models
{ 
    public class OrderModel: IHasId
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        [ForeignKey("ItemId")]
        public ItemMode Item { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
