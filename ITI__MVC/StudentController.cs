using Microsoft.AspNetCore.Mvc;
using DAY4.Models;
using DAY4.Models.ViewModels;
using System.Linq;

public class StudentController : Controller
{
    private readonly List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "Ahmed", Age = 22, Address = " Nasr city", Department = "IT", Manager = "dr.Ali " },
        new Student { Id = 2, Name = "mona", Age = 26, Address = "el maadi", Department = "HR", Manager = "Eng. Samy" },
        new Student { Id = 3, Name = "sara", Age = 24, Address = "cairo ", Department = "Marketing", Manager = "dr.Khalid" },
        new Student { Id = 4, Name = "Khalid", Age = 28, Address = "giza", Department = "IT", Manager = "dr.Ali " },
        new Student { Id = 5, Name = "lila", Age = 21, Address = "duqqi ", Department = "HR", Manager = "Eng. Samy" },
        new Student { Id = 6, Name = "tarek", Age = 30, Address = "elzmalek", Department = "Marketing", Manager = "dr.Khalid" },
        new Student { Id = 7, Name = "nour", Age = 23, Address = "elmohandesin", Department = "IT", Manager = "dr.Ali " },
        new Student { Id = 8, Name = "fatma", Age = 29, Address = "shobra", Department = "HR", Manager = "Eng. Samy " },
        new Student { Id = 9, Name = "Hussain", Age = 25, Address = "tanta", Department = "Marketing", Manager = "dr.Khalid" },
        new Student { Id = 10, Name = "Mariam ", Age = 20, Address = "tanta", Department = "IT", Manager = "dr.Ali " },
    };

    public IActionResult Index(int page = 1) // ASP.NET Core يستخدم IActionResult
    {
        int pageSize = 5;
        var studentListVMs = students.Select(s => new StudentListVM
        {
            StId = s.Id,
            StName = s.Name,
            StAge = s.Age,
            DeptName = s.Department,
            ManagerName = s.Manager
        }).ToList();

        var paginatedStudents = studentListVMs.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = (int)Math.Ceiling((double)studentListVMs.Count / pageSize);

        return View(paginatedStudents);
    }

    public IActionResult Details(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            return NotFound();
        }

        var studentDetailsVM = new StudentDetailsVM
        {
            StName = student.Name,
            StAddress = student.Address,
            DeptName = student.Department,
            ManagerName = student.Manager,
            StageColor = student.Age < 25 ? "green" : "red"
        };

        return View(studentDetailsVM);
    }
}
