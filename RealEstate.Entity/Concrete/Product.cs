using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductType { get; set; }
        public decimal UnitPrice { get; set; }
        public string Title { get; set; }
        public string ProductSize { get; set; }
    }
}
