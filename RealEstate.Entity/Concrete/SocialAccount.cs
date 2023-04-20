using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Entity.Abstract;

namespace RealEstate.Entity.Concrete
{
    public class SocialAccount : IEntity
    {
        public int SocialAccountID { get; set; }
        public string Title { get; set; }
        public string SocialUrl { get; set; }
    }
}
