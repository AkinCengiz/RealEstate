using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class Address : IEntity
    {
        [Key] 
        public int AddressID { get; set; }

        public string District { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mail1 { get; set; }
        public string Mail2 { get; set; }
        public string MapInfo { get; set; }
    }
}
