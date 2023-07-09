using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.Services;

public interface INoteUserService
{
    public Task<NoteUser[]> GetAllUsers();
}