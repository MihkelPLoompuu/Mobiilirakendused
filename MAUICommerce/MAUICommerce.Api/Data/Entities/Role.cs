using MAUICommerce.Api.Constants;
using System.ComponentModel.DataAnnotations;

namespace MAUICommerce.Api.Data.Entities
{
    public class Role
    {
        [Key]
        public short Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }

        internal static IEnumerable<Role> GetInitialRoles() =>
            new List<Role>
            {
                new Role
                {
                    Id = DatabaseConstants.Roles.Admin.Id,
                    Name = DatabaseConstants.Roles.Admin.Name
                },
                new Role
                {
                    Id = DatabaseConstants.Roles.Customer.Id,
                    Name = DatabaseConstants.Roles.Customer.Name
                }
            };
    }
}
