using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RealEstate.DataAccess.Abstract;
using RealEstate.Entity.Abstract;

namespace RealEstate.Business.Abstract
{
    public interface IGenericService<TGenericDal,TEntity> where TGenericDal : class, IGenericDal<TEntity>,new() where TEntity : class, IEntity,new()
    {
        List<TEntity> GetAll();
        TEntity GetById(Expression<Func<TEntity, bool>> id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
