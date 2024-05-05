using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string? BookName { get; set; }

        
        public int AuthId { get; set; }
        public int CatId { get; set; }

        public string? Edition { get; set; }
        public string? BookNo { get; set; }

        public string? BookPrice { get; set; }

        [ForeignKey("AuthId")]
        public required Author Author { get; set; }
        [ForeignKey("CatId")]
        public required Category Category { get; set; }
    }
}
