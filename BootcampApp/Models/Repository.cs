namespace BootcampApp.Models
{
    public class Repository{
        private static List<UserInfo> _user = new();

        static Repository(){
            _user.Add(new UserInfo(){Id=1,Name = "Ahmet", Email="asd@asd.com",Phone="111111",WillAttend=true});
            _user.Add(new UserInfo(){Id=2,Name = "Mehmet", Email="asd@asd.com",Phone="111111",WillAttend=true});
            _user.Add(new UserInfo(){Id=3,Name = "Ayşe", Email="asd@asd.com",Phone="111111",WillAttend=false});
        }

        public static List<UserInfo> Users{
            get{return _user;
            }
        }
        public static void CreateUser(UserInfo user){

            user.Id = Users.Count +1;
            _user.Add(user);
        }

        public static UserInfo? GetByID(int id){
            return _user.FirstOrDefault(user => user.Id == id);
        }
        

    }
}