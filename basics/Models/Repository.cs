namespace basics.Models
{
    public class Repository{

        private static readonly List<Bootcamp> _bootcamp = new();

        static Repository(){
            _bootcamp = new List<Bootcamp>(){
                new Bootcamp(){
                    Id = 1,
                    Title="Asp.Net Core Bootcamp",Description = "Kayseri'de gerçekleşecek.",
                    Image="1.jpg",
                    Tags = new string[]{"aspnet","web geliştirme"},
                    isActive = true,
                    isHome = true                    
                    },
                new Bootcamp(){
                    Id = 2,
                    Title="Data Bootcamp",
                    Description = "Kayseri'de gerçekleşecek.",
                    Image="2.jpg",
                    Tags = new string[]{"data","veri"},
                    isActive = true,
                    isHome = true 
                    },
                new Bootcamp(){Id = 3,
                Title="Back-End Bootcamp",
                Description = "Kayseri'de gerçekleşecek.",
                Image="3.jpg",
                isActive = true,
                isHome = true 
                },
                new Bootcamp(){Id = 4,
                Title="Game Bootcamp",
                Description = "Kayseri'de gerçekleşecek.",
                Image="4.jpg",
                isActive = true,
                isHome = true 
                }
            };
        }

        public static List<Bootcamp> Bootcamps{
            get{
                return _bootcamp;
            }
        }

        public static Bootcamp? GetById(int? id){
            return _bootcamp.FirstOrDefault(c => c.Id == id);
        }
    }
}