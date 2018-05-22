using System;
using System.Collections.Generic;
using System.Text;
using KanBagisiMVC.Kizilay.Business.Abstract;
using KanBagisiMVC.Kizilay.DataAccess.Abstract;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.Business.Concrete
{
    public class BagisciManager : IBagisciService
    {
        private readonly IBagisciDal _bagisciDal;

        public BagisciManager(IBagisciDal bagisciDal)
        {
            _bagisciDal = bagisciDal;
        }

        public void Add(Bagisci bagisci)
        {
            _bagisciDal.Add(bagisci);
        }

        public void Delete(int tcNo)
        {
             _bagisciDal.Delete(new Bagisci{TcNo = tcNo});
        }

        public List<Bagisci> GetAll()
        {
            return _bagisciDal.GetList();
        }

        public List<Bagisci> GetByKanGrubu(string kanGrubu)
        {
            return _bagisciDal.GetList(x => x.KanGrubu == kanGrubu);
        }

        public void Update(Bagisci bagisci)
        {
            _bagisciDal.Update(bagisci);
        }
    }
}
