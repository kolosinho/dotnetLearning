using Core.Interfaces.Repositories;
using Core.Models;
using Data.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private DbApplicationContext context;

        public CommentRepository(DbApplicationContext context)
        {
            this.context = context;
        }

        public void SaveComment(string commentMessage, string userName)
        {
            Comment[] comments1 = context.Comments
                .ToArray();

            Comment[] comments2 = context.Comments
                .Where(c => c.UserName == "Dima")
                .ToArray();

            Comment[] comments3 = context.Comments
                .Where(c => c.CommentMessage.Contains("Hello"))
                .ToArray();

            int countRecords = context.Comments.Count();

            Comment comment = new Comment
            {
                CommentMessage = commentMessage,
                UserName = userName
            };

            context.Comments.Add(comment);
            context.SaveChanges();
        }
    }
}
