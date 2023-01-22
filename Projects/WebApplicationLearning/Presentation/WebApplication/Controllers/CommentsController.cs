using Core.Interfaces.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentManager commentManager;

        public CommentsController(ICommentManager commentManager)
        {
            this.commentManager = commentManager;
        }

        [HttpPost]
        public IActionResult LeaveComment(string message, string userName)
        {
            bool isCommentLeft = commentManager.LeaveComment(message, userName);

            return Ok(new
            {
                isCommentLeft = isCommentLeft
            });
        }
    }
}
