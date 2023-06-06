using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfKonular
{
    public decimal Id { get; set; }

    public decimal TurId { get; set; }

    public decimal SiraNo { get; set; }

    public decimal FDonemId { get; set; }

    public string? Konu { get; set; }

    public virtual PerfDonem FDonem { get; set; } = null!;

    public virtual ICollection<PerfSorular> PerfSorulars { get; set; } = new List<PerfSorular>();
}
