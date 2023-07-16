using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.Repositories;

public interface INoteUserRepository
{
    public Task<NoteUser[]> GetAllUsersAsync();

    public Task CreateUserAsync(NoteUser noteUser);

    public Task DeleteUsersByIdsAsync(int[] usersIds);

    public Task<NoteUser?> GetUserByIdAsync(int id);

    public Task UpdateUserAsync(NoteUser noteUser);
}