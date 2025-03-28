﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAUICommerce.Api.Data.Entities
{
    [Table(nameof(Offer))]
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }

        [Required, MaxLength(10)]
        public string Code { get; set; }

        [Required, MaxLength(10)]
        public string BgColor { get; set; }
        public bool IsActive { get; set; }
        public Offer(int id, string title, string description, string bgColor, string code) : this()
        {

            Id = id;
            Title = title;
            Description = description;
            BgColor = bgColor;
            Code = code;
        }
        public Offer()
        {

        }
        private static readonly string[] _lightColors = new string[]
        {
            "#e1f1e7", "#dad1f9", "#ffff00", "#d0f200", "#e28083", "#7fbdc7", "#ea978d"
        };
        private static string RandomColor => _lightColors.OrderBy(c => Guid.NewGuid()).First();

        public static IEnumerable<Offer> GetInitialData() =>
            new List<Offer>()
            {
                 new Offer(1,"Up to 30% off", "Enjoy up to 30% off on all products", RandomColor, "FRT30"),
                 new Offer(2,"Green Veg Big Sale 50% OFF", "Enjoy our big offer of 50% off on all green vegetables", RandomColor, "500FF"),
                 new Offer(3,"FLAT 100% OFF", "Flat Rs. 100 off on all exotic fruits and vegetables", RandomColor, "EXT100"),
                 new Offer(4,"25% OFF on Seasonal Fruits", "Enjoy 25% off on all seasonal fruits", RandomColor, "FRT25")
            };
    }
}
