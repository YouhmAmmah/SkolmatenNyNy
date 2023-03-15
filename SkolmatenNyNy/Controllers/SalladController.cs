using Microsoft.AspNetCore.Mvc;
using SkolmatenNyNy.Models;

namespace SkolmatenNyNy.Controllers
{
    public class SalladController : Controller
    {
        public IActionResult Index()
        {
            using (MatContext db = new MatContext())
            {
                List<Mat> matLista = db.Ratter.ToList();

                return View(matLista);
            }

        }

        public IActionResult Detaljer(int id)
        {
            using (MatContext db = new MatContext())
            {
                List<Mat> matLista = db.Ratter.ToList();
                Mat valdMat = matLista.FirstOrDefault(model => model.Id == id);
                return View(valdMat);
            }

        }
    }
}
