using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAUICommerce.Api.Data.Entities
{
    [Table(nameof(Category))]
    public class Category
    {
        [Key]
        public short Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(150)]
        public string Image { get; set; }

        public short ParentId { get; set; }
        [MaxLength(300)]
        public string? Credit { get; set; }

        public Category(short id, string name, string image, short parentId, string credit)
        {
            Id = id;
            Name = name;
            Image = image;
            ParentId = parentId;
            Credit = credit;
        }
        public Category()
        {

        }
        public static IEnumerable<Category> GetInitialData()
        {
            var categories = new List<Category>();

            var fruits = new List<Category>
                {
                   new(1, "Fruits", 0,"fruit.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Blackberryraspberrystrawberry.jpg/220px-Blackberryraspberrystrawberry.jpg"),
                   new(2, "Seasonal Fruits", 1,"seasonalfruit.jpg", "Photo by <a href=\"https://www.krusteaz.com/wp-content/uploads/2024/06/Summer.png"),
                   new(3, "Exotic Fruits", 1,"exoticfruit.jpg", "Photo by <a href=\"https://static-resources.mirai.com/wp-content/uploads/sites/1738/20241217100716/1.-Frutas-tropicales-Caribe.jpg")
                };
            categories.AddRange(fruits);

            var vegetables = new List<Category>
                {
                   new(4, "Vegetables", 0,"vegetables.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Marketvegetables.jpg/220px-Marketvegetables.jpg"),
                   new(5, "Green Vegetables", 4,"greenvegetables.jpg", "Photo by <a href=\"https://healthwire.pk/wp-content/uploads/2022/08/green-leafy-vegetables.jpg"),
                   new(6, "Leafy Vegetables", 4,"leafyvegetables.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Spinach_leaves.jpg/220px-Spinach_leaves.jpg"),
                   new(7, "Salads", 4,"salad.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Salad_platter.jpg/220px-Salad_platter.jpg")
                };
            categories.AddRange(vegetables);

            var dairy = new List<Category>
                {
                   new(8, "Dairy", 0,"dairy.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Dairy_products.jpg/220px-Dairy_products.jpg"),
                   new(9, "Milk, Crud & Yogurts", 8,"milk.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/a/a5/Glass_of_Milk_%2833657535532%29.jpg"),
                   new(10, "Butter & Cheese", 8,"buttercheese.jpg", "Photo by <a href=\"https://img.choice.com.au/-/media/bb10da0168384d8ab2d2888fb2341f52.ashx")
                };
            categories.AddRange(dairy);

            var eggMeat = new List<Category>
                {
                    new(11, "Eggs & Meat", 0,"eggsmeat.jpg", "Photo by <a href=\"https://cdn.bakedbree.com/uploads/2024/01/A_FEATURE4_BB-STEAK-AND-EGGS-500x500.jpg"),
                    new(12, "Eggs", 11,"eggs.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Six_eggs_views_from_the_top_on_a_white_background.jpg/220px-Six_eggs_views_from_the_top_on_a_white_background.jpg"),
                    new(13, "Meat", 11,"meat.jpg", "Photo by <a href=\"https://www.allrecipes.com/thmb/zN81HQ86Fa2rHnkH-KUvUf6pBZE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Cuts-of-Beef-3x2-1-a557f31f8b13462185b4f2c17ab5b746.png"),
                    new(14, "SeaFood", 11,"seafood.jpg", "Photo by <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Plateau_van_zeevruchten.jpg/330px-Plateau_van_zeevruchten.jpg")
                };
            categories.AddRange(eggMeat);
        }     
    }
}
