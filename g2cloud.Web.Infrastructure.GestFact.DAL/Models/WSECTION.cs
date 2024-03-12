using System;
using System.Collections.Generic;

namespace g2cloud.Web.Infrastructure.GestFact.DAL;

public partial class WSECTION
{
    public string COD_WSE { get; set; } = null!;

    public string WSE_NOM { get; set; } = null!;

    public string COD_WSI { get; set; } = null!;

    public string WSE_CSS { get; set; } = null!;

    public string WSE_EST { get; set; } = null!;

    public double WSE_CNT { get; set; }

    public string WSE_OBS { get; set; } = null!;

    public string? WSE_TAG { get; set; }

    public DateTime? WSE_FUE { get; set; }

    public string WSE_REG { get; set; } = null!;

    public string WSE_LCK { get; set; } = null!;

    public DateTime? WSE_UPD { get; set; }

    public DateTime WSE_FAL { get; set; }
}
