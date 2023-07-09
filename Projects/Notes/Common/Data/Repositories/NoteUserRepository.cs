using System.Threading.Tasks;
using Core.Interfaces.Repositories;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class NoteUserRepository : INoteUserRepository
{
    private readonly NotesDbContext _dbContext;
    
    public NoteUserRepository(NotesDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<NoteUser[]> GetAllUsers()
    {
        return await _dbContext.NoteUsers.ToArrayAsync();
    }
}