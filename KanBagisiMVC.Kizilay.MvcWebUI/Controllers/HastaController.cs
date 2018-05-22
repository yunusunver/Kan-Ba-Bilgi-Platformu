using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KanBagisiMVC.Kizilay.Business.Abstract;
using KanBagisiMVC.Kizilay.Entities.Concrete;
using KanBagisiMVC.Kizilay.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KanBagisiMVC.Kizilay.MvcWebUI.Controllers
{
    public class HastaController:Controller
    {
        private IHastaService _hastaService;

        public HastaController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }


        public ActionResult KanIhtiyaci()
        {
            var hastalar = _hastaService.GetAll();
            HastaListViewModel model = new HastaListViewModel
            {
                Hastas = hastalar.OrderByDescending(x=>x.Tarih).ToList()
            };
            return View(model);
        }

        public ActionResult AnonsGec()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AnonsGec(Hasta hasta,string kanGrubu)
        {
            if (ModelState.IsValid)
            {
                hasta.Tarih = DateTime.Now;
                hasta.KanGrubu = kanGrubu;
                _hastaService.Add(hasta);

            }
            var hastalar = _hastaService.GetAll();
            HastaListViewModel model = new HastaListViewModel
            {
                Hastas = hastalar.OrderByDescending(x => x.Tarih).ToList()
            };
            return RedirectToAction("KanIhtiyaci",model);
        }
    }
}
