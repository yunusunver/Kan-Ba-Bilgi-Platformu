using KanBagisiMVC.Core.DataAccess.EntityFramework;
using KanBagisiMVC.Kizilay.DataAccess.Abstract;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.DataAccess.Concrete.EntityFramework
{
    public class EfHastaDal : EfEntityRepositoryBase<Hasta,KizilayDbContext>, IHastaDal
    {
    }
}