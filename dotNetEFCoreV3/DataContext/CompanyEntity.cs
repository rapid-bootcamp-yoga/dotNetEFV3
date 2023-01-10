using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNetEFCoreV3.DataContext
{
    [Table("tbl_company")]
    public class CompanyEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("category_name")]
        public String CompanyName { get; set; }

        [Column("segmentasi")]
        public String Segmentasi { get; set; }

        [Column("address")]
        public String Address { get; set; }

        [Column("logo")]
        public String Logo { get; set; }

        public CompanyEntity()
        {

        }
    }
}
