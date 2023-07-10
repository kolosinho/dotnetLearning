using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Notes.ViewModels.Home;

namespace Notes.Controllers;

public class NoteUserController : Controller
{
    private INoteUserService _noteUserService;
    private IMapper _mapper;
    
    public NoteUserController(INoteUserService noteUserService, IMapper mapper)
    {
        _noteUserService = noteUserService;
        _mapper = mapper;
    }

    public async Task<IActionResult> List()
    {
        IndexViewModel model = new IndexViewModel();
        NoteUser[] users = await _noteUserService.GetAllUsers();
        model.Users = _mapper.Map<IndexViewModel.NoteUser[]>(users);
        
        return View(model);
    }
}
