using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.DataAccess.Abstract;
using RealEstate.DataAccess.Concrete.Repository;
using RealEstate.Entity.Concrete;

namespace RealEstate.DataAccess.Concrete.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact,RealEstateContext>,IContactDal
    {
    }
}
