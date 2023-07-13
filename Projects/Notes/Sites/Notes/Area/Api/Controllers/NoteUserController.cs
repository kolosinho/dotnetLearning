using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Notes.Area.Api.ApiModels.Requests;
using Notes.Area.Api.ApiModels.Responses;

namespace Notes.Area.Api.Controllers;

[Route("api/[controller]")]
public class NoteUserController : Controller
{
    private readonly INoteUserService _noteUserService;
    private readonly IMapper _mapper;
    
    public NoteUserController(INoteUserService noteUserService, IMapper mapper)
    {
        _noteUserService = noteUserService;
        _mapper = mapper;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAllUsers()
    {
        NoteUser[] users = await _noteUserService.GetAllUsersAsync();

        GetUsersResponse response = new GetUsersResponse();
        response.Users = _mapper.Map<GetUsersResponse.NoteUser[]>(users);
        
        return Json(response);
    }
    
    [HttpDelete("delete-users")]
    public async Task<IActionResult> DeleteUsers([FromBody] DeleteUsersRequest request)
    {
        await _noteUserService.DeleteUsersByIdsAsync(request.UsersIds);
        
        return Ok();
    }
}