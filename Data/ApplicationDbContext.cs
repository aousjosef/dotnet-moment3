using Microsoft.EntityFrameworkCore;
using Moment_3.Models;

namespace Moment_3.Data;

public class ApplicationDbContext : DbContext
{

    //Konstruktor för att påbörja anslutning
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }

    public DbSet<Book> Books { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Loan> Loans { get; set; }

}

