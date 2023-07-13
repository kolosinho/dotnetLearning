using System.Linq;
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
    
    public async Task<NoteUser[]> GetAllUsersAsync()
    {
        return await _dbContext.NoteUsers.ToArrayAsync();
    }

    public async Task DeleteUsersByIdsAsync(int[] usersIds)
    {
        await _dbContext.NoteUsers
            .Where(nu => usersIds.Contains(nu.Id))
            .ExecuteDeleteAsync();
            
    }
}