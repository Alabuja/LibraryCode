using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCode.Models
{
    [Table("Authors")]
    public class AuthorModel
    {
        public long Id { get; set; }
        public string AuthorName { get; set; }
        public string EmailAddress { get; set; }
    }
}
