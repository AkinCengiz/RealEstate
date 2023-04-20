using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Business.Abstract;
using RealEstate.DataAccess.Abstract;
using RealEstate.Entity.Abstract;

namespace RealEstate.Business.Concrete
{
    public class GenericManager<TEntityDal, TEntity> : IGenericService<TEntityDal, TEntity> where TEntityDal : class, IGenericDal<TEntity>, new() where TEntity : class, IEntity, new()

    {
        TEntityDal _entityDal = new TEntityDal();
        public TEntity GetById(Expression<Func<TEntity, bool>> id)
        {
            return _entityDal.GetById(id);
        }

        public void Add(TEntity entity)
        {
            _entityDal.Insert(entity);
        }

        public void Delete(TEntity entity)
        {
            _entityDal.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return  _entityDal.GetAll();
        }


        public void Update(TEntity entity)
        {
           _entityDal.Update(entity);
        }
    }
}
