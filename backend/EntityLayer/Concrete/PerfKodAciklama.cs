using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfKodAciklama
{
    public decimal Id { get; set; }

    public decimal FDonemId { get; set; }

    public decimal? TurId { get; set; }

    public string? Aciklama { get; set; }

    public string? Puan { get; set; }

    public virtual PerfDonem FDonem { get; set; } = null!;
}
