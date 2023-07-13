using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.Repositories;

public interface INoteUserRepository
{
    public Task<NoteUser[]> GetAllUsersAsync();

    public Task DeleteUsersByIdsAsync(int[] usersIds);
}