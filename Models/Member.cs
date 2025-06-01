using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        // A member can borrow many books
        public virtual ICollection<BorrowedBook>? BorrowedBooks { get; set; }

    }
}
