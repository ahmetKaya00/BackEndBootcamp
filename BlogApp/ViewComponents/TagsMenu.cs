using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogApp.ViewComponents 
{
    public class TagsMenu: ViewComponent
    {
        private ITagRepository _tagrapository;

        public TagsMenu(ITagRepository tagRepository){
            _tagrapository = tagRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            return View(await _tagrapository.Tags.ToListAsync());
        }

    }
}