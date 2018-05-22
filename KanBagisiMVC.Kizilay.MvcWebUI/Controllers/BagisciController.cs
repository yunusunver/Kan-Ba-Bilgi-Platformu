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
    public class BagisciController:Controller
    {
        private IBagisciService _bagisciService;

        public BagisciController(IBagisciService bagisciService)
        {
            _bagisciService = bagisciService;
        }

        public ActionResult Index()
        {
            var bagiscilar = _bagisciService.GetAll();
            BagisciListViewModel model= new BagisciListViewModel
            {
                Bagiscis= bagiscilar
            };
            return View(model);
        }

        public ActionResult BagisciBilgileri()
        {
            var bagiscilar = _bagisciService.GetAll();
            BagisciListViewModel model = new BagisciListViewModel
            {
                Bagiscis = bagiscilar.OrderByDescending(x => x.Tarih).ToList()
            };
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult HayatKurtar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult HayatKurtar(Bagisci bagisci,string kanGrubu)
        {
            if (ModelState.IsValid)
            {
                bagisci.Tarih=DateTime.Now;
                bagisci.KanGrubu = kanGrubu;
                _bagisciService.Add(bagisci);
            }
            var bagiscilar = _bagisciService.GetAll();
            BagisciListViewModel model = new BagisciListViewModel
            {
                Bagiscis = bagiscilar
            };
            return RedirectToAction("BagisciBilgileri",model);
        }


    }
}
