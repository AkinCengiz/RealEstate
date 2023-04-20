using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class FeatureService : IEntity
    {
        [Key]
        public int FeatureServiceID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageIcon { get; set; }
    }
}
