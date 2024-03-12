using System;
using System.Collections.Generic;

namespace g2cloud.Web.Infrastructure.GestFact.DAL;

public partial class WSITE
{
    public string COD_WSI { get; set; } = null!;

    public string WSI_NOM { get; set; } = null!;

    public string WSI_ALI { get; set; } = null!;

    public string WSI_EST { get; set; } = null!;

    public string WSI_URL { get; set; } = null!;

    public string WSI_PRO { get; set; } = null!;

    public string WSI_PUE { get; set; } = null!;

    public string WSI_PUEDEF { get; set; } = null!;

    public string WSI_OBS { get; set; } = null!;

    public string? WSI_TAG { get; set; }

    public DateTime? WSI_FUE { get; set; }

    public string WSI_REG { get; set; } = null!;

    public string WSI_LCK { get; set; } = null!;

    public DateTime? WSI_UPD { get; set; }

    public DateTime WSI_FAL { get; set; }
}
