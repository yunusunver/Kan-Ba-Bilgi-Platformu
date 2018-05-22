using KanBagisiMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KanBagisiMVC.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //İstenilen veriyi çeker
        T Get(Expression<Func<T,bool>> filter=null);

        //Listelemek için kullanılır.
        List<T> GetList(Expression<Func<T,bool>> filter=null);

        //Veri eklemek için kullanılır.
        void Add(T entity);

        //Veri güncellemek için kullanılır.
        void Update(T entity);

        //Veri silmek kullanılır.
        void Delete(T entity);

    }
}
