using System;
using System.Collections.Generic;
using System.Text;
using KanBagisiMVC.Kizilay.Entities.Concrete;

namespace KanBagisiMVC.Kizilay.Business.Abstract
{
    public interface IBagisciService
    {
        List<Bagisci> GetAll();
        List<Bagisci> GetByKanGrubu(string kanGrubu);
        void Add(Bagisci bagisci);
        void Update(Bagisci bagisci);
        void Delete(int tcNo);

    }
}
