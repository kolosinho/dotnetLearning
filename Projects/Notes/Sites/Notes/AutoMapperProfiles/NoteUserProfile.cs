using AutoMapper;
using Core.Models;
using Notes.ViewModels.Home;
using Notes.ViewModels.NoteUser;

namespace Notes.AutoMapperProfiles;

public class NoteUserProfile : Profile
{
    public NoteUserProfile()
    {
        CreateMap<NoteUser, IndexViewModel.NoteUser>()
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.FirstName + " " + src.LastName)
            );

        CreateMap<NoteUser, NoteUserViewModel>().ReverseMap();
    }
}