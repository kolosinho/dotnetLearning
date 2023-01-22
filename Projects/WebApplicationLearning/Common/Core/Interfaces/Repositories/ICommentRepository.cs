namespace Core.Interfaces.Repositories
{
    public interface ICommentRepository
    {
        public void SaveComment(string comment, string userName);
    }
}
