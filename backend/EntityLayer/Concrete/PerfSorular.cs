using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfSorular
{
    public decimal Id { get; set; }

    public decimal FKonuId { get; set; }

    public decimal FKonuTurId { get; set; }

    public decimal FKonuSiraNo { get; set; }

    public decimal FDonemId { get; set; }

    public decimal? SiraNo { get; set; }

    public string? Soru { get; set; }

    public virtual PerfKonular F { get; set; } = null!;

    public virtual ICollection<PerfDegerlendirme> PerfDegerlendirmes { get; set; } = new List<PerfDegerlendirme>();
}
