using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfDegerlendirme
{
    public decimal FCalisanId { get; set; }

    public decimal FDonemId { get; set; }

    public decimal FKonuId { get; set; }

    public decimal FKonuTurId { get; set; }

    public decimal FKonuSiraNo { get; set; }

    public decimal FSoruId { get; set; }

    public decimal? Puan { get; set; }

    public decimal? Amirmi { get; set; }

    public virtual PerfCalisanAmirListe F { get; set; } = null!;

    public virtual PerfSorular FNavigation { get; set; } = null!;
}
