﻿using MAUICommerce.Api.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAUICommerce.Api.Data.Entities
{
    [Table(nameof(User))]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string Mobile { get; set; }
        public short RoleId { get; set; }

        [Required, MaxLength(25)]
        [Comment("We should not have plain password. Having this just for simplicity and demo purpose")]
        public string Password { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

        public static IEnumerable<User> GetInitialUsers() =>
            new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Mihkel Ploompuu",
                    Email = "mihkelploompuu@gmail.com",
                    Mobile = "1234567890",
                    Password = "12345",
                    RoleId = DatabaseConstants.Roles.Admin.Id
                }
            };
    }
}
