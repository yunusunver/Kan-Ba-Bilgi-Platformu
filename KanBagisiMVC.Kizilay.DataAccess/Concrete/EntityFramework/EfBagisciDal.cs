using System;
using System.Collections.Generic;
using System.Text;
using KanBagisiMVC.Core.DataAccess.EntityFramework;
using KanBagisiMVC.Kizilay.DataAccess.Abstract;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.DataAccess.Concrete.EntityFramework
{
    public class EfBagisciDal:EfEntityRepositoryBase<Bagisci,KizilayDbContext>,IBagisciDal
    {
    }
}
