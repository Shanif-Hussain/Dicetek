using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dicetek.ServiceContracts;
using System.Linq;

namespace Dicetek.MvcWebApplication.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegistersService _regservice;

        public RegisterController(IRegistersService regservice)
        {
            _regservice = regservice;
        }

        // GET: Register
        public async Task<IActionResult> Index()
        {
            //var data = await _regservice.GetRegisteredUserList();
            //return View(data.AsEnumerable());

            return View(await _regservice.GetRegisteredUserList());
        }


        // GET: Register/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,firstName,lastName,emailId,mobileNo,creditCard,ccExpiryDate,ccv")] DomainModels.RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                await _regservice.RegisterNewUser(registerModel);
                return RedirectToAction(nameof(Index));
            }
            return View(registerModel);
        }

    }
}
