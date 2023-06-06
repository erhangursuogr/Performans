using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class VPerfCalisanAmir
{
    public string? GorevYeriAdi { get; set; }

    public string? SicilBirimi { get; set; }

    public string? CalistigiBirim { get; set; }

    public string? Adsoyad { get; set; }

    public string? Amir1 { get; set; }

    public string? Amir2 { get; set; }

    public decimal DonemId { get; set; }

    public decimal GorevYeri { get; set; }

    public decimal OrgBirimKodu { get; set; }

    public decimal SicilBirimkodu { get; set; }

    public string TcKimlikNo { get; set; } = null!;

    public string? A1TcKimlikNo { get; set; }

    public decimal? A1IdariGorevKodu { get; set; }

    public string? A2TcKimlikNo { get; set; }

    public decimal? A2IdariGorevKodu { get; set; }

    public string? Onay { get; set; }

    public string? Aktar { get; set; }

    public decimal? KadroUnv1 { get; set; }

    public decimal? KadroUnv2 { get; set; }
}
