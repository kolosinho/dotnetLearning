using System;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Notes.ViewModels.Home;
using Notes.ViewModels.NoteUser;

namespace Notes.Controllers;

public class NoteUserController : Controller
{
    private readonly INoteUserService _noteUserService;
    private readonly IMapper _mapper;
    
    public NoteUserController(INoteUserService noteUserService, IMapper mapper)
    {
        _noteUserService = noteUserService;
        _mapper = mapper;
    }

    public async Task<IActionResult> List()
    {
        IndexViewModel model = new IndexViewModel();
        NoteUser[] users = await _noteUserService.GetAllUsersAsync();
        model.Users = _mapper.Map<IndexViewModel.NoteUser[]>(users);
        
        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(NoteUserViewModel model)
    {
        NoteUser noteUser = _mapper.Map<NoteUser>(model);
        await _noteUserService.CreateUserAsync(noteUser);

        return RedirectToAction("List");
    }

    [HttpPost]
    public async Task<IActionResult> Edit(NoteUserViewModel model)
    {
        NoteUser noteUser = _mapper.Map<NoteUser>(model);
        await _noteUserService.UpdateUserAsync(noteUser);

        return RedirectToAction("List");
    }
    
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        NoteUser? noteUser = await _noteUserService.GetUserById(id);
        NoteUserViewModel model = _mapper.Map<NoteUserViewModel>(noteUser);
        
        return View(model);
    }
}
