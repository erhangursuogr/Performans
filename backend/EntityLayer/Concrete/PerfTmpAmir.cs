using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfTmpAmir
{
    public decimal DonemId { get; set; }

    public string TcKimlikNo { get; set; } = null!;

    public decimal IdariGorevKodu { get; set; }

    public decimal GorevKurumYeri { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? IdariGorev { get; set; }

    public decimal? GorevBirimKodu { get; set; }

    public string? OrgBirimAdi { get; set; }

    public decimal? OrgBirimKodu { get; set; }

    public decimal? OrgUstBirimKodu { get; set; }

    public decimal? OrgEnustBirimKodu { get; set; }

    public decimal? OrgSicilBirimkodu { get; set; }

    public string? AnabilimAdi { get; set; }

    public decimal? AnabilimKodu { get; set; }

    public decimal? KOrgBirimKodu { get; set; }

    public string? KOrgBirimAdi { get; set; }

    public decimal? KAnabilimKodu { get; set; }

    public string? KAnabilimAdi { get; set; }

    public DateTime? GorevBasTar { get; set; }

    public DateTime? GorevBitTar { get; set; }

    public decimal? ArsivYil { get; set; }

    public decimal? ArsivNo { get; set; }

    public decimal? GorevYeri { get; set; }

    public decimal? KadroYeri { get; set; }

    public decimal? KadroUnv1 { get; set; }

    public decimal? KadroUnv2 { get; set; }

    public decimal? AkadUnv1 { get; set; }

    public decimal? AkadUnv2 { get; set; }

    public decimal? KadroDurumu { get; set; }

    public string? SicilNo { get; set; }

    public string? GorevNereden { get; set; }

    public string? Aktif { get; set; }

    public decimal? KurumTip { get; set; }

    public string? Aciklama { get; set; }

    public string? InsertBilgi { get; set; }

    public string? UpdateBilgi { get; set; }
}
