using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetEFCoreV3.DataContext
{
    [Table("tbl_product")]
    public class ProductEntity
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("product_name")]
        public String ProductName { get; set; }

        [Column("category")]
        public String Category { get; set; }

        [Column("price")]
        public int Price { get; set; }


        public ProductEntity()
        {

        }
    }
}
