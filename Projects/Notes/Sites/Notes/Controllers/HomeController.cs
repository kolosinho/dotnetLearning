using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Notes.Models;
using Notes.ViewModels.Home;

namespace Notes.Controllers;

public class HomeController : Controller
{
    private INoteUserService _noteUserService;
    private IMapper _mapper;
    public HomeController(INoteUserService noteUserService, IMapper mapper)
    {
        _noteUserService = noteUserService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        IndexViewModel model = new IndexViewModel();

        NoteUser[] users = await _noteUserService.GetAllUsers();

        model.Users = _mapper.Map<IndexViewModel.NoteUser[]>(users);
        
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}