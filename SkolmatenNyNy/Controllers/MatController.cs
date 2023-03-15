using Microsoft.AspNetCore.Mvc;
using SkolmatenNyNy.Models;

namespace SkolmatenNyNy.Controllers
{
    public class MatController : Controller
    {
        public IActionResult Index()
        {
            List<Mat> matLista = SkapaMatLista();

            return View(matLista);
        }

        public IActionResult Detaljer(int id) 
        {
            List<Mat> matLista = SkapaMatLista();
            Mat valdMat = matLista.FirstOrDefault(model => model.Id == id);
            return View(valdMat);
        }
    }
}
