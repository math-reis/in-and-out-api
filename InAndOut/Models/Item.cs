using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }

    }
}