using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfDonem
{
    public decimal Id { get; set; }

    public decimal? Yil { get; set; }

    public decimal? Donem { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Durum { get; set; }

    public virtual ICollection<PerfCalisanAmirListe> PerfCalisanAmirListes { get; set; } = new List<PerfCalisanAmirListe>();

    public virtual ICollection<PerfKodAciklama> PerfKodAciklamas { get; set; } = new List<PerfKodAciklama>();

    public virtual ICollection<PerfKodKariyer> PerfKodKariyers { get; set; } = new List<PerfKodKariyer>();

    public virtual ICollection<PerfKonular> PerfKonulars { get; set; } = new List<PerfKonular>();
}
