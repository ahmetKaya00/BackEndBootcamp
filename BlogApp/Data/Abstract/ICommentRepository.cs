using BlogApp.Entitiy;

namespace BlogApp.Data.Abstract
{
    public interface ICommentRepository{
        IQueryable<Comment> Comments {get;}

        void CreatePost(Comment comment);
    }
}