using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class BorrowedBook
    {
        [Key]
        public int BorrowId { get; set; }

        public int MemberId { get; set; }

        public int BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }


        public virtual required Member Member { get; set; }

        public virtual required Book Book { get; set; }
    }
}
