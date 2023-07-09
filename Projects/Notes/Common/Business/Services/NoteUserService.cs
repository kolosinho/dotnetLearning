using System.Threading.Tasks;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Models;

namespace Business.Services;

public class NoteUserService : INoteUserService
{
    private readonly INoteUserRepository _noteUserRepository;

    public NoteUserService(INoteUserRepository noteUserRepository)
    {
        _noteUserRepository = noteUserRepository;
    }
    
    public async Task<NoteUser[]> GetAllUsers()
    {
        return await _noteUserRepository.GetAllUsers();
    }
}