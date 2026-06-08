using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
    // Action: responde a /Produto/Index
    public IActionResult Index()
    {
        ViewBag.Nome = "Leonardo Miranda Ferreira Lopes";
        
        ViewBag.Curso = "ADS - Análise em Desenvolvimento de Sistemas";
    
        ViewBag.Semestre = "1º - Primeiro Semestre";
        return View();
    }

    // Action: responde a /Produto/Detalhes/5
    public IActionResult Detalhes(int id)
    {
        ViewBag.ProdutoId = id;
        return View();
    }
}