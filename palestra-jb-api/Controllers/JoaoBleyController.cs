using Microsoft.AspNetCore.Mvc;

namespace palestra_jb_api.Controllers;

[ApiController]
[Route("[controller]")]
public class JoaoBleyController : ControllerBase
{

    public JoaoBleyController() { }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("API do João Bley");
    }

    [HttpGet("Sortear")]
    public IActionResult Sortear()
    {
        List<string> alunos = new()
        {
            "Igor",
            "Penha",
            "Jesus",
            "Henrique",
            "Camila",
        };

        return Ok(SortearStrings(alunos).FirstOrDefault());
    }

    static List<string> SortearStrings(List<string> lista)
    {
        Random random = new Random();
        List<string> listaSorteada = lista.OrderBy(x => random.Next()).ToList();
        return listaSorteada;
    }
}