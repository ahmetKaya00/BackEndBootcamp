using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Tags.Any())
                {
                        context.Tags.AddRange(
                    new Tag {Text = "web programala", Url ="web-programlama" , Color = TagColors.success},
                    new Tag {Text = "Unity", Url ="unity-game", Color = TagColors.warning},
                    new Tag {Text = "php", Url ="php-dersleri", Color = TagColors.primary},
                    new Tag {Text = "sql", Url ="sql-dersleri", Color = TagColors.info}
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "ahmetkaya", Name = "Ahmet Kaya", Email = "info@ahmetkaya.com", Password="123456", Image = "p1.jpg"},
                        new User { UserName = "mesudekaya", Name = "Mesude Kaya", Email = "info@mesudekaya.com", Password="123456", Image = "p2.jpg"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                    new Post{
                        Title = "Asp.net core",
                        Content="Asp.net core dersleri güzeldir",
                        Description="Asp.net core dersleri güzeldir",
                        Url ="aspnet-core",
                        IsActive = true,
                        Image = "1.jpg",
                        PublishedOn = DateTime.Now.AddDays(-5),
                        Tags = context.Tags.Take(3).ToList(),
                        UserId = 1,
                        Comments = new List<Comment>{
                            new Comment {Text = "Güzel bir post tebrikler", PublishedOn = new DateTime(),UserId = 1},
                            new Comment {Text = "Güzel bir içerik", PublishedOn = new DateTime(),UserId = 2},
                        }
                    },
                    new Post{
                        Title = "Unity Game",
                        Content="Unity ile oyun geliştirebilirsiniz",
                        Description="Unity ile oyun geliştirebilirsiniz",
                        Url ="unity-game",
                        IsActive = true,
                        Image = "2.jpg",
                        PublishedOn = DateTime.Now.AddDays(-20),
                        Tags = context.Tags.Take(3).ToList(),
                        UserId = 1,
                    },
                    new Post{
                        Title = "Php",
                        Content="Php ile web geliştir.",
                        Description="Php ile web geliştir.",
                        Url ="php-dersleri",
                        IsActive = true,
                        Image = "3.jpg",
                        PublishedOn = DateTime.Now.AddDays(-15),
                        Tags = context.Tags.Take(3).ToList(),
                        UserId = 1
                    }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}