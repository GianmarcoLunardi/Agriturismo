using Agriturismo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Agriturismo.Service;
using Agriturismo.Models;
using AutoMapper;

/// <summary>
/// Controller Appartamenti
/// </summary>
namespace Agriturismo.Controllers.administrator
{
    [Area("Administrator")]
    public class  HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Irepo<Appartament, int> Appartament; // Aooartament Service
        private readonly IMapper  map;

              public HomeController(ILogger<HomeController> logger, Irepo<Appartament, int> App, IMapper _m )
        {
            _logger = logger;
            Appartament = App;
            map = _m;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Procedure for the 
        public IActionResult ApartmentsList()
        {
            return View(Appartament.GetAll());
        }

        //  Add Apartmerts
        public IActionResult ApartmentsAdd()
        { /*
           
            AppartamentVM Data;
            if (id == null)
            {
                Data = new AppartamentVM();
            }
            else
            {
       
                Data = Appartament.Get((int)id);




            };
            
                     
            Appa
*/          Appartament dato = new Appartament();
             AppartamentVM DatoVM = map.Map<Appartament, AppartamentVM>(dato);
            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> ApartmentsAdd(AppartamentVM id )
        {
            if (ModelState.IsValid)
            {
                Appartament AppAinseted = map.Map<AppartamentVM, Appartament>(id);
                await Appartament.add(AppAinseted);
                return RedirectToAction("Index");
            }
            else
            {

            }

            return RedirectToAction("ApartmentsAdd");
            
        }
        // visualizza tutti gli appartamenti
        public async Task<IActionResult> ApartmentsDisplay()
        {
            //await Appartament.GetAll();
            return View(await Appartament.GetAll());
        }

        public async Task<IActionResult> ApartmentsDetails(int id)
        {
            //await Appartament.GetAll();
            AppartamentVM app = map.Map<Appartament, AppartamentVM>(await Appartament.Get(id));
            return View(app);
        }

        [HttpGet]
        public async Task<IActionResult> ApartmentsDelete(int id)
        {
            //await Appartament.GetAll();
            Appartament v = await Appartament.Get(id);
            //await Appartament.delete(v);
           // Appartamentapp = map.Map<Appartament, AppartamentVM>(await );
            return View(v);
        }

        [HttpPost]
        public async Task<IActionResult> ApartmentsDelete2(int idd)
        {
            //await Appartament.GetAll();
            Appartament v = await Appartament.Get(idd);
            await Appartament.delete(v);
            // Appartamentapp = map.Map<Appartament, AppartamentVM>(await );
            return View(v);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
