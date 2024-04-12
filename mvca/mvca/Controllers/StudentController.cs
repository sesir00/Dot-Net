using Microsoft.AspNetCore.Mvc;

namespace mvca.Controllers
{
    public class StudentController : Controller
    {
        //controller is used to handle incoming http request. it contains group of action method that returns particular view but it is 
        //not mandatory to have view for each
        public IActionResult Index()
        {
            return View();
        }
        public string PrintName()
        {
            return "hello csit 6th sem";
        }

        public string PrintRoll(int id)
        {
            return $"roll of student is {id}";
        }
        public string PrintStudent(string name, int roll)
        {
            return $"name having name {name} has roll {roll}";
        }
    }

 }

