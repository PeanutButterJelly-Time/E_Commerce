using System.ComponentModel.DataAnnotations;

namespace Web.Models.Products
{
    public class Beer : Product
    {
        [Display(Name = "Beer Style")]
        [EnumDataType(typeof(BeerStyle))]
        public BeerStyle BeerStyle { get; set; }

        [Display(Name = "Alcohol by Volume")]
        public double Abv { get; set; }

        [Display(Name = "IBU")]
        public int Ibu { get; set; }
    }

    public enum BeerStyle
    {
        // There is no 0
        IPA = 1,
        Sour,
        Stout,
        Saison,
        Gose,
    }
}