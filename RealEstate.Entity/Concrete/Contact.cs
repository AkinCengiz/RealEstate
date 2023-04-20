using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public DateTime DateInfo { get; set; }
    }
}
