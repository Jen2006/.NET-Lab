using Microsoft.AspNetCore.Mvc;
using Student.Models;


namespace Student.Controllers
{
    public class STUDENTController : Controller
    {
        public IActionResult Index()
        {   
            List <STUDENT> students = new List<STUDENT>
            {
                new STUDENT { USN = 09, Name = "Onovesho", Sub1 = 85, Sub2 = 90, Sub3 = 78 },
                new STUDENT { USN = 32, Name = "Jenisho", Sub1 = 88, Sub2 = 76, Sub3 = 92 },
                new STUDENT { USN = 58, Name = "Rohul", Sub1 = 90, Sub2 = 89, Sub3 = 84 }
            };


            return View(students);
        }
    }
}
