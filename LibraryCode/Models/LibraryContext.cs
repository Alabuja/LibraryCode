using Microsoft.EntityFrameworkCore;

namespace LibraryCode.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BorrowedBookModels> BorrowedBooks { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
