using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfCalisanAmirListe
{
    public decimal Id { get; set; }

    public decimal FDonemId { get; set; }

    public string? TcKimlikNo { get; set; }

    public decimal? IdariGorevKodu { get; set; }

    public decimal? PerformansPuani { get; set; }

    public decimal? GorevYeri { get; set; }

    public decimal? GorevBirimKodu { get; set; }

    public decimal? SicilBirimkodu { get; set; }

    public string? AdiSoyadi { get; set; }

    public string? Sicilno { get; set; }

    public DateTime? BasTar { get; set; }

    public string? KadroUnv1 { get; set; }

    public string? KadroUnv2 { get; set; }

    public string? AkdUnv1 { get; set; }

    public string? AkdUnv2 { get; set; }

    public string? Amirmi { get; set; }

    public string? Degerlendirme { get; set; }

    public string? Kilit { get; set; }

    public string? AmirOnay { get; set; }

    public string? GeriBildirim { get; set; }

    public string? Itiraz { get; set; }

    public string? Komisyon { get; set; }

    public string? AmirGorus { get; set; }

    public string? IptalNedeni { get; set; }

    public string? GucluyonAciklama { get; set; }

    public string? GelistirmeAciklama { get; set; }

    public string? Aciklama { get; set; }

    public string? ItirazAciklama { get; set; }

    public string? KomisyonAciklama { get; set; }

    public string? A1TcKimlikNo { get; set; }

    public decimal? A1IdariGorevKodu { get; set; }

    public string? A2TcKimlikNo { get; set; }

    public decimal? A2IdariGorevKodu { get; set; }

    public string? AmirTcKimlikNo { get; set; }

    public decimal? AmirIdariGorevKodu { get; set; }

    public string? A1Update { get; set; }

    public string? AmirUpdate { get; set; }

    public decimal? A1Debisid { get; set; }

    public decimal? AmirDebisid { get; set; }

    public virtual PerfDonem FDonem { get; set; } = null!;

    public virtual ICollection<PerfDegerlendirme> PerfDegerlendirmes { get; set; } = new List<PerfDegerlendirme>();

    public virtual ICollection<PerfKariyer> PerfKariyers { get; set; } = new List<PerfKariyer>();
}
