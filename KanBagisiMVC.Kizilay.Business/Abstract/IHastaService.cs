using System.Collections.Generic;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.Business.Abstract
{
    public interface IHastaService
    {
        List<Hasta> GetAll();
        List<Hasta> GetByKanGrubu(string kanGrubu);
        void Add(Hasta bagisci);
        void Update(Hasta bagisci);
        void Delete(int tcNo);
    }
}