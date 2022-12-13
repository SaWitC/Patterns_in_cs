using System.ComponentModel.DataAnnotations.Schema;

namespace DI_REpository_UnitOfWork.Models
{
    public class OrderModel//simple model 1
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserModel User { get; set; }
    }
}
