using MAUICommerce.Shared.Enumerations;
using System.Drawing;

namespace MAUICommerce.Api.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public short RoleId { get; set; }
        public string Password { get; set; }

        public virtual Role Role { get; set; }
    }
    public class Role
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }
    public class Category
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public short ParentId { get; set; }
        public string? Credit { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public short CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
    public class Order
    {
        public long Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set;}
        public OrderStatus Status { get; set; } = OrderStatus.Placed;
    }
    public class OrderTime
    {
        public Guid Id { get; set; }
        public long OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }   
        public decimal Amount { get; set; }

        public virtual Order Order { get; set; }
    }
}
