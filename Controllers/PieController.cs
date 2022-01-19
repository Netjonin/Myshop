using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Repositories;
using MyShop.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepo;
        private readonly ICategoryRepository _cateRepo;

        public PieController(IPieRepository pieRepo, ICategoryRepository cateRepo)
        {
            _pieRepo = pieRepo;
            _cateRepo = cateRepo;

        }

        public ViewResult List()
        {
            ViewBag.CurrentCategory = "Cheese cakes";
            return View(_pieRepo.AllPies);
        }
    }
}
