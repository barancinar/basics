using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller
{
    public IActionResult Index()
    {
        var course= new Course();
        course.Id=1;
        course.Title=".Net Course";
        course.Description="Güzel bir kurs";
        course.Image="1.png";

        return View(course);
    }
    public IActionResult Details(int? id)
    {
        if (id==null)
        {
            return RedirectToAction("list", "course");
        }
        else if(id>Repository.Courses.Count) 
        {
            return RedirectToAction("List","Course");
        }
        var course=new Course();
        course = Repository.GetById(id);

        return View(course);
    }

    public IActionResult List() 
    { 
        return View("CourseList", Repository.Courses);
    }

}