using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfKariyer
{
    public decimal FKariyerId { get; set; }

    public decimal FCalisanId { get; set; }

    public decimal FDonemId { get; set; }

    public decimal? SiraNo { get; set; }

    public string? EvetHayir { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public virtual PerfCalisanAmirListe F { get; set; } = null!;

    public virtual PerfKodKariyer FKariyer { get; set; } = null!;
}
