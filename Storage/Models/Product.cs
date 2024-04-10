using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Orderdate { get; set; }
        public string Category { get; set; }
        
        [Required]
        public string Shelf { get; set; }
        
        [Range(1,9999)]
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
