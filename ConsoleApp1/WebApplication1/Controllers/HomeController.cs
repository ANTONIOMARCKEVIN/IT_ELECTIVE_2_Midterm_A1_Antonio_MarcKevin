using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Welcome"] = "I am a BS in Information Technology student passionate about technology and problem-solving, aiming to kickstart a career as an IT Support Professional post-graduation. Eager to apply academic training in networking, security, and hardware diagnostics to real-world help desk environment challenges.\r\n";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        ViewData["About Me"] = "As an Information Technology student, I sit at the intersection of technical infrastructure and user experience. My background spans database tracking, system design, and a strong specialization in UI/UX design, giving me a unique perspective on how humans interact with technology.\r\n";
        ViewData["About Me2"] = "I am aiming to launch my career in IT Support, where I can use my technical troubleshooting abilities alongside my design mindset. Whether I am diagnosing hardware logic challenges, optimizing backend workflows, or guiding a user through a complex interface, my goal is always to make technology seamless, functional, and user-friendly.\r\n";
        ViewData["Quick Background"] = "BS in Information Technology";
        ViewData["Quick Background2"] = "Design";
        ViewData["Quick Background3"] = "IT Support";
        ViewData["Quick Background4"] = "UI/UX";
        return View();

    }

    public IActionResult Skills()
    {
        ViewData["Programming"] = "C#, Java, Python, SQL";
        return View();
    }
    public IActionResult Projects()
    {
        ViewData["Periodic Elements"] = "An interactive application showcasing chemical elements, their atomic properties, and periodic trends.";
        return View();
    }
    public IActionResult Contact()
    {
        ViewData["Mobile Number"] = "+63 931 704 5834";
        ViewData["Email Address"] = "Klyneskevin0818@gmail.com";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}