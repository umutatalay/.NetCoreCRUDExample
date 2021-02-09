using Microsoft.AspNetCore.Mvc;
using NetCoresubat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.ViewComponents
{

    public class Kategori:ViewComponent
    {
        private readonly ICategoriesRepository _kategoriRepository; // readonly olmazsa hata veriyor.

        public Kategori(ICategoriesRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_kategoriRepository.GetAll());
        }
    }
}
