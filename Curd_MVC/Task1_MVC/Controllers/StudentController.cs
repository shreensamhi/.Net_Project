using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Task1_MVC.Models;
namespace Task1_MVC.Controllers
{
    public class StudentController : Controller
    {
        AppDbContext Context = new AppDbContext();

        public IActionResult getStudent(int id)
        {

            var student = Context.Students. FirstOrDefault(s => s.StudentId == id);
            return View(student);
        }

        public IActionResult getStudents()
        {
            ViewModel studentDepartment = new ViewModel();
             studentDepartment.Students = Context.Students.ToList();
            studentDepartment.Departments = Context.Departments.ToList();
            return View(studentDepartment);
        }

        public IActionResult removeStudent(int id)
        {
            if (ModelState.IsValid)
            {

                var student = Context.Students.FirstOrDefault(s => s.StudentId == id);
                Context.Students.Remove(student);
                Context.SaveChanges();
                return RedirectToAction("getStudents");
            }
            return Content("NotFound");
        }
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudentActual(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student != null && !string.IsNullOrEmpty(student.Name))
                {
                    Context.Students.Add(student);
                    Context.SaveChanges();
                    return RedirectToAction("getStudents");
                }
                return View(student);
            }



            return RedirectToAction("Success");
        }

        public IActionResult EditStudent(int id)
        {
            var std = Context.Students.FirstOrDefault(s => s.StudentId == id);
            return View(std);
        }
        [HttpPost]
        public IActionResult EditStudentActual(Student student)
        {
            if (ModelState.IsValid)
            {

                var std = Context.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
                if (std != null)
                {

                    std.Name = student.Name;
                    std.DepartmentId = student.DepartmentId;
                    std.age = student.age;
                    std.adress = student.adress;
                    Context.Students.Update(std);
                    Context.SaveChanges();
                    return RedirectToAction("getStudents");
                }
               
            }
            return RedirectToAction("Success");
        }






    }
}
