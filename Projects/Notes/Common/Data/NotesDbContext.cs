using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class NotesDbContext : DbContext
{
    public DbSet<NoteUser> NoteUsers { get; set; } = null!;

    public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NoteUser>().HasData(
            new NoteUser { Id = 1, FirstName = "Andriy", LastName = "Svyryd", Age = 55 },
            new NoteUser { Id = 2, FirstName = "Dmytro", LastName = "Bevziuk", Age = 23 });
    }
}