using System;
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
    
    public async Task<NoteUser[]> GetAllUsersAsync()
    {
        return await _noteUserRepository.GetAllUsersAsync();
    }
    
    public async Task DeleteUsersByIdsAsync(int[] usersIds)
    {
        if (usersIds.Length == 0)
        {
            throw new ArgumentException();
        }
        
        await _noteUserRepository.DeleteUsersByIdsAsync(usersIds);
    }
}