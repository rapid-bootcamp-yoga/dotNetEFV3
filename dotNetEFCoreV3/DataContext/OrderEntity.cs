using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetEFCoreV3.DataContext
{
    [Table("tbl_order")]
    public class OrderEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("count")]
        public int Count { get; set; }

        [Column("description")]
        public String Description { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public OrderEntity()
        {

        }
    }
}
