using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.Products
{
    public class Beer : Product
    {
        [EnumDataType(typeof(BeerStyle))]
        public BeerStyle BeerStyle { get; set; }
        public double Abv { get; set; }
        public int Ibu { get; set; }
    }


    public enum BeerStyle
    {
        IPA,
        Sour,
        Stout,
        Saison,
        Gose,
    }

}
