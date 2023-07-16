using System;
using System.Runtime.CompilerServices;
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
    
    public async Task<NoteUser?> GetUserById(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException();
        }
        
        return await _noteUserRepository.GetUserByIdAsync(id);
    }

    public async Task CreateUserAsync(NoteUser noteUser)
    {
        if (noteUser == null)
        {
            throw new ArgumentException();
        }

        await _noteUserRepository.CreateUserAsync(noteUser);
    }

    public async Task UpdateUserAsync(NoteUser noteUser)
    {
        if (noteUser == null)
        {
            throw new ArgumentException();
        }

        await _noteUserRepository.UpdateUserAsync(noteUser);
    }
}