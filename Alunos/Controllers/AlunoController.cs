using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Leonardo Miranda Ferreira Lopes";
        
        ViewBag.Curso = "ADS - Análise em Desenvolvimento de Sistemas";
    
        ViewBag.Semestre = "1º - Primeiro Semestre";
        return View();
    }

    
    public IActionResult Detalhes(int id)
    {
        ViewBag.AlunoId = id;
        return View();
    }
}