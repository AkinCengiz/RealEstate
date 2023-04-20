using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public byte CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDetails { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
