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

        private List<Mat> SkapaMatLista()
        {
            List<Mat> matLista = new List<Mat>();
            
            Mat minMat = SkapaMat(1, "Fiskpanetter", 4, "Överanvänd, men ok");
            matLista.Add(minMat);
            
            matLista.Add(new Mat(20, "Pasta carbonara", 9, "Väldigt god, med gräddig"));

            minMat = SkapaMat(2, "Chili con carne", 7, "God, får nachos ibland");
            matLista.Add(minMat);

            minMat = SkapaMat(3, "Veggopajer", 9, "Väldigt god men ingen kött");

            matLista.Add(minMat);

            return matLista;
        }
        private Mat SkapaMat(int id, string maten, int betyg, string beskrivning)
        {
            Mat mat = new Mat(id, maten, betyg, beskrivning);
            return mat;
        }
    }
}
