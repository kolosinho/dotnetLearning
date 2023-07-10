using AutoMapper;
using Core.Models;
using Notes.Area.Api.ApiModels.Responses;

namespace Notes.Area.Api.ApiProfiles;

public class NoteUserProfile : Profile
{
    public NoteUserProfile()
    {
        CreateMap<NoteUser, GetUsersResponse.NoteUser>()
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.FirstName + " " + src.LastName)
            );
    }
}