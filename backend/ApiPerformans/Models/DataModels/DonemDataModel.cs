namespace ApiPerformans.Models.DataModels
{
    public class DonemDataModel
    {
        public int Id { get; set; }
        public int Yil { get; set; }
        public int Donem { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string? Durum { get; set; }
    }
}