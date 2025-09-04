using ITI_DAY4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace ITI_DAY4.Controllers
{



    public class StudentController : Controller
    {
        private List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "أحمد", Age = 22, Address = "مدينة نصر", Department = "IT", Manager = "د. علي" },
        new Student { Id = 2, Name = "منى", Age = 26, Address = "المعادي", Department = "HR", Manager = "م. سامي" },
        new Student { Id = 3, Name = "سارة", Age = 24, Address = "مصر الجديدة", Department = "Marketing", Manager = "أ. خالد" },
        new Student { Id = 4, Name = "خالد", Age = 28, Address = "الجيزة", Department = "IT", Manager = "د. علي" },
        new Student { Id = 5, Name = "ليلى", Age = 21, Address = "الدقي", Department = "HR", Manager = "م. سامي" },
        new Student { Id = 6, Name = "طارق", Age = 30, Address = "الزمالك", Department = "Marketing", Manager = "أ. خالد" },
        new Student { Id = 7, Name = "نور", Age = 23, Address = "المهندسين", Department = "IT", Manager = "د. علي" },
        new Student { Id = 8, Name = "فاطمة", Age = 29, Address = "شبرا", Department = "HR", Manager = "م. سامي" },
        new Student { Id = 9, Name = "حسين", Age = 25, Address = "وسط البلد", Department = "Marketing", Manager = "أ. خالد" },
        new Student { Id = 10, Name = "مريم", Age = 20, Address = "مدينة نصر", Department = "IT", Manager = "د. علي" },
    };

        public ActionResult GetStsAllData(int page = 1)
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

        public ActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            

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
}