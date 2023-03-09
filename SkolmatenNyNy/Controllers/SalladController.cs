using Microsoft.AspNetCore.Mvc;
using SkolmatenNyNy.Models;

namespace SkolmatenNyNy.Controllers
{
    public class SalladController : Controller
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

            Mat minMat = SkapaMat(4, "Keso", 10, "gott, nyttigt, och ett måste-ha vid varje måltid. Det ända tråkiga är att det inte alltdi finns.");
            matLista.Add(minMat);

            minMat = SkapaMat(5, "Morötter", 3, "Är ok, bra om det inte finns någon annan, godare sallad");
            matLista.Add(minMat);

            minMat = SkapaMat(6, "Tonfiskröra", 9, "Väldigt god men ibland finns det någon konstig senapssmak i den. Vet inte vad det kan bero på");

            matLista.Add(minMat);

            return matLista;
        }

        //Constructor (mindre för att det finns en i model)
        private Mat SkapaMat(int id, string maten, int betyg, string beskrivning)
        {
            Mat mat = new Mat( id, maten, betyg, beskrivning);
            return mat;
        }
    }
}
