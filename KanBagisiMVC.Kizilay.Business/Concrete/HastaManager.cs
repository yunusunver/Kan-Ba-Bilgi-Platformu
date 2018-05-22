using System;
using System.Collections.Generic;
using System.Text;
using KanBagisiMVC.Kizilay.Business.Abstract;
using KanBagisiMVC.Kizilay.DataAccess.Abstract;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.Business.Concrete
{
    public class HastaManager : IHastaService
    {
        private IHastaDal _hastaDal;

        public HastaManager(IHastaDal hastaDal)
        {
            _hastaDal = hastaDal;
        }

        public void Add(Hasta bagisci)
        {
            _hastaDal.Add(bagisci);
        }

        public void Delete(int tcNo)
        {
            _hastaDal.Delete(new Hasta{TcNo = tcNo});
        }

        public List<Hasta> GetAll()
        {
            return _hastaDal.GetList();
        }

        public List<Hasta> GetByKanGrubu(string kanGrubu)
        {
            return _hastaDal.GetList(x => x.KanGrubu == kanGrubu);
        }

        public void Update(Hasta bagisci)
        {
            _hastaDal.Update(bagisci);
        }
    }
}
