namespace SkolmatenNyNy.Models
{
    public class Mat
    {
        public int Id { get; set; }
        public string Maten { get; set; }
        public int Betyg { get; set; }
        public string Beskrivning { get; set; }

        public Mat()
        {

        }

        public Mat(int id, string maten, int betyg, string beskrivning)
        {
            Id = id;
            Maten = maten;
            Betyg = betyg;
            Beskrivning = beskrivning;
        }   
    }
}
