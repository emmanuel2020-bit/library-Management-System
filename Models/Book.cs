using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Status { get; set; }

        //  A book can be borrowed many times
        public virtual ICollection<BorrowedBook>? BorrowedBooks { get; set; }
    }
}
