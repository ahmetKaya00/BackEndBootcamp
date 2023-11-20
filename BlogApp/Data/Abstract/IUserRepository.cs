using BlogApp.Entitiy;

namespace BlogApp.Data.Abstract
{
    public interface IUserRepository{
        IQueryable<User> Users {get;}

        void CreateUser(User user);
    }
}