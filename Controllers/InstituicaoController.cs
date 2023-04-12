using Apoio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Apoio.Controllers
{
    
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
    {
        new Instituicao()
        {
            Id = 1,
            Name = "Casa",
            Endereco = "Polonia"
        },
        new Instituicao()
        {
            Id=2,
            Name = "Casarão",
            Endereco = "Suiça"
        }
    };
        public IActionResult Index()
        {
             return View(instituicoes);
            
            
        }
    }
}
