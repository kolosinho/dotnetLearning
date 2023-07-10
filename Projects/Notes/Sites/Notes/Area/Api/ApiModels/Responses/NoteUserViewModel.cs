namespace Notes.Area.Api.ApiModels.Responses;

public class GetUsersResponse
{
    public NoteUser[]? Users { get; set; }
    
    public class NoteUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}