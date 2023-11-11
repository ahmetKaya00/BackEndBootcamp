namespace FormsApp.Models
{
    public class Repository{
        private static readonly List<Product> _product = new();
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category{CategoryId =1, Name="Telefon"});
            _categories.Add(new Category{CategoryId =2, Name="Bilgisayar"});

            _product.Add(new Product{ProductId = 1, Name ="Iphone",Price=50000, IsActive=true, Image = "1.jpg", CategoryId = 1});
            _product.Add(new Product{ProductId = 2, Name ="Iphone",Price=70000, IsActive=true, Image = "2.jpg", CategoryId = 1});
            _product.Add(new Product{ProductId = 3, Name ="Monster",Price=30000, IsActive=true, Image = "3.jpg", CategoryId = 2});
        }
        public static List<Product> Product {
            get{
                return _product;
            }
        }

        public static void CreateProduct(Product entity){
            _product.Add(entity);
        }

        public static void EditProduct(Product updatedProduct){

            var entity = _product.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null){
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.IsActive = updatedProduct.IsActive;
                entity.CategoryId = updatedProduct.CategoryId;
            }
        }

        public static void DeleteProduct(Product deletedProduct){
            var entity = _product.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if(entity != null){
                _product.Remove(entity);
            }
        }

        public static List<Category> Categories{
            get{
                return _categories;
            }
        }


    }
    
}