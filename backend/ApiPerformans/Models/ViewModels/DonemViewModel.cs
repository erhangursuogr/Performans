namespace ApiPerformans.Models.ViewModels
{
    public class DonemViewModel
    {
        public int Yil { get; set; } = DateTime.Now.Year;
        public int Donem { get; set; } = 1;
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string? Durum { get; set; } = "1";
    }
}