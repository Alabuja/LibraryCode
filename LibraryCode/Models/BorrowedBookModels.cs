using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCode.Models
{
    [Table("BorrowedBooks")]
    public class BorrowedBookModels
    {
        public long Id { get; set; }
        public DateTime DateBorrowed { get; set; }
        public long BookId { get; set; }
        public BookModel Book { get; set; }
        public long UserId { get; set; }
        public UserModel User { get; set; }
    }
}
