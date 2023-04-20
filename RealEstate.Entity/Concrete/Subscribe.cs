using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class Subscribe : IEntity
    {
        [Key]
        public int SubscribeID { get; set; }
        public string Mail { get; set; }
    }
}
