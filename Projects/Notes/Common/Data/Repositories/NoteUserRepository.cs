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

    public async Task CreateUserAsync(NoteUser noteUser)
    {
        _dbContext.NoteUsers.Add(noteUser);

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteUsersByIdsAsync(int[] usersIds)
    {
        await _dbContext.NoteUsers
            .Where(nu => usersIds.Contains(nu.Id))
            .ExecuteDeleteAsync();            
    }
    
    public async Task<NoteUser?> GetUserByIdAsync(int id)
    {
        return await _dbContext.NoteUsers.FirstOrDefaultAsync(nu => nu.Id == id);
    }
    
    public async Task UpdateUserAsync(NoteUser noteUser)
    {
        _dbContext.NoteUsers.Update(noteUser);

        await _dbContext.SaveChangesAsync();
    }
}