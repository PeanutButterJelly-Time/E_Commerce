using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Shoe : Product
    {
        public Style Style { get; set; }
    }
    public enum Style
    {
        Low,
        Mid,
        High,
    }
    
}
