using Microsoft.AspNetCore.Mvc;
using NetCoresubat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.ViewComponents
{
    public class Urun:ViewComponent
    {
        private readonly IProductRepository _urunRepository;

        public Urun(IProductRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(_urunRepository.GetAll());
        }
    }
}
