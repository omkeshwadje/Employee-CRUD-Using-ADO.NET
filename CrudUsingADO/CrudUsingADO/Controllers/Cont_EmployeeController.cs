using CrudUsingADO.Models;
using CrudUsingADO.Service;
using Microsoft.AspNetCore.Mvc;

namespace CrudUsingADO.Controllers
{
    public class Cont_EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<EmployeeModel> employeescnt = new List<EmployeeModel>();
            EmpDAL empcnt = new EmpDAL();

            employeescnt = empcnt.GetEmployeeDetails();


            return View(employeescnt);
        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
    
            EmployeeModel employeescnt = new EmployeeModel();
            EmpDAL empcnt = new EmpDAL();

            employeescnt = empcnt.GetEmployeeById(id);

            return View(employeescnt);
        }

        [HttpPost]
        public IActionResult EditEmployeeDetails(int Employee_Code, EmployeeModel EmpDetails) 
        {
           
            try
            {
                if (ModelState.IsValid)
                {

                    EmpDAL _DBemp = new EmpDAL();

                    if (_DBemp.EditEmployeeDetailsDAL(Employee_Code,EmpDetails))
                    {

                        return RedirectToAction("Index");
                    }
                }

                return View();

            }
            catch
            {
                return View();
            }
        }

    
       
        public ActionResult CreateEmployee() {
          
            return View();

        }
               
        [HttpPost]
        public ActionResult CreateNewEmp(EmployeeModel EmpDetails) {
               
                
                try
                {
               
                if (ModelState.IsValid)
                 {
                  
                    EmpDAL _DBemp = new EmpDAL();
                    
                    if (_DBemp.InsertEmployee(EmpDetails))
                        {
                        
                        return RedirectToAction("Index");
                        }
                 }

                return View();

                }
                catch
                {
                
                return View();

                }
        }



        public IActionResult DeleteEmployee(int id)
        {

            EmployeeModel employeescnt = new EmployeeModel();
            EmpDAL empcnt = new EmpDAL();

            employeescnt = empcnt.DeleteEmployee(id);

            return View(employeescnt);
        }

        public IActionResult DeleteEmployeeDetails(int Employee_Code)
        {
            
            try
            {

                if (ModelState.IsValid)
                {

                    EmpDAL _DBemp = new EmpDAL();

                    if (_DBemp.DeleteEmployeeDetailsDAL(Employee_Code))
                    {

                        return RedirectToAction("Index");
                    }
                }

                return View();

            }
            catch
            {
                return View();
            }
        }



        public IActionResult EmployeeDetails(int id)
        {

            EmployeeModel employeescnt = new EmployeeModel();
            EmpDAL empcnt = new EmpDAL();

            employeescnt = empcnt.DetailsOfEmployee(id);

            return View(employeescnt);
        }





    }
}
