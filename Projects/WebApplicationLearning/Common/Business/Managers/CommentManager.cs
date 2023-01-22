using Core.Interfaces.Managers;
using Core.Interfaces.Repositories;

namespace Business.Managers
{
    public class CommentManager : ICommentManager
    {
        private readonly ICommentRepository commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }
        
        public bool LeaveComment(string comment, string userName)
        {
            bool isCommentSaved = false;

            if (!string.IsNullOrWhiteSpace(comment) && !string.IsNullOrWhiteSpace(userName))
            {
                commentRepository.SaveComment(comment, userName);

                isCommentSaved = true;
            }

            return isCommentSaved;
        }
    }
}
