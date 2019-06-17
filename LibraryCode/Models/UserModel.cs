using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCode.Models
{
    [Table("Users")]
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string HouseAddress { get; set; }
    }
}
