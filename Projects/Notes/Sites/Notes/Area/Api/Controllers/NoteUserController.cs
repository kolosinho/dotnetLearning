using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
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

    public async Task<IActionResult> Index()
    {
        NoteUser[] users = await _noteUserService.GetAllUsers();

        GetUsersResponse response = new GetUsersResponse();
        response.Users = _mapper.Map<GetUsersResponse.NoteUser[]>(users);
        
        return Json(response);
    }
}