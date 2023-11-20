using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.Entitiy;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Controllers
{
    public class PostsController : Controller{
        private IPostRepository _postRepository;
        private ICommentRepository _commentRepository;
        public PostsController(IPostRepository postRepository,ICommentRepository commentRepository){
            _postRepository = postRepository;
            _commentRepository = commentRepository;

        }

        public async Task<IActionResult> Index(string tag){

            var claims = User.Claims;

            var posts = _postRepository.Posts;
            if(!string.IsNullOrEmpty(tag)){
                posts = posts.Where(x=>x.Tags.Any(t=>t.Url == tag));
            }
            return View(
                new PostsViewModel{ Posts = await posts.ToListAsync()});
        }

        public async Task<IActionResult> Details(string url){
            return View(await _postRepository
                        .Posts
                        .Include(x => x.Tags)
                        .ThenInclude(x=>x.Comments)
                        .ThenInclude(x=>x.User)
                        .FirstOrDefaultAsync(p=>p.Url == url));
        }

        public IActionResult AddComment(int PostId, string UserName,string Text, string Url){

            var entitiy = new Comment{
                Text = Text,
                PublishedOn = DateTime.Now,
                PostID = PostId,
                User = new User{UserName = UserName, Image="p1.jpg"}
            };
            _commentRepository.CreatePost(entitiy);

            return RedirectToRoute("post_details", new {url = Url});
        }
    }
}