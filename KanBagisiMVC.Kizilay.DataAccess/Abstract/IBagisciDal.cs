using System;
using System.Collections.Generic;
using System.Text;
using KanBagisiMVC.Core.DataAccess;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.DataAccess.Abstract
{
    public interface IBagisciDal:IEntityRepository<Bagisci>
    {
        //Stored Procedure ,View, Sorgu yazılabilir
    }
}
