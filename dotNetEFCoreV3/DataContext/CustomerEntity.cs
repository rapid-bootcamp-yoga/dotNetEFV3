using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetEFCoreV3.DataContext
{
    [Table("tbl_customer")]
    public class CustomerEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_name")]
        public String CustomerName { get; set; }

        [Column("email")]
        public String Email { get; set; }

        [Column("password")]
        public String Password { get; set; }

        public CustomerEntity()
        {

        }
    }
}
