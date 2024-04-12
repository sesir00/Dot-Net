using Microsoft.AspNetCore.Mvc;
using EFCodeNCCS.Models;
namespace EFCodeNCCS.Controllers
    //controller is responsible 
{
    public class StudentController: Controller
    {
        //setting the object of student context
        private readonly StudentContext sc;
        public StudentController(StudentContext sc)
        {
            this.sc = sc;
        }









        //creating action method 
        public  IActionResult AddStudent()
        {
            return View();
        }
    }
}
