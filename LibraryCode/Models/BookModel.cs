using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCode.Models
{
    [Table("Books")]
    public class BookModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public long AuthorId { get; set; }
        public AuthorModel Author { get; set; }
    }
}
