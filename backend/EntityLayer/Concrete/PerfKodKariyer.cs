using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete;

public partial class PerfKodKariyer
{
    public decimal Id { get; set; }

    public decimal FDonemId { get; set; }

    public decimal? SiraNo { get; set; }

    public string? Aciklama { get; set; }

    public virtual PerfDonem FDonem { get; set; } = null!;

    public virtual ICollection<PerfKariyer> PerfKariyers { get; set; } = new List<PerfKariyer>();
}
