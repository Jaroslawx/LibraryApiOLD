using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Review> Reviews { get; set; }
}