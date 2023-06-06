using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfCalisanAmir
{
    public decimal DonemId { get; set; }

    public string TcKimlikNo { get; set; } = null!;

    public decimal GorevYeri { get; set; }

    public decimal IdariGorevKodu { get; set; }

    public decimal GorevBirimKodu { get; set; }

    public decimal OrgBirimKodu { get; set; }

    public decimal OrgUstBirimKodu { get; set; }

    public decimal SicilBirimkodu { get; set; }

    public string? BirimAdi { get; set; }

    public string? A1TcKimlikNo { get; set; }

    public string? A2TcKimlikNo { get; set; }

    public decimal? A1IdariGorevKodu { get; set; }

    public decimal? A2IdariGorevKodu { get; set; }

    public string? Onay { get; set; }

    public string? Aktar { get; set; }

    public string? OnayBilgi { get; set; }

    public string? UpdateBilgi { get; set; }
}
