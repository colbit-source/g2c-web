using System;
using System.Collections.Generic;

namespace g2cloud.Web.Infrastructure.GestFact.DAL;

public partial class WPAGE
{
    public string COD_WPA { get; set; } = null!;

    public string COD_WSI { get; set; } = null!;

    public string WPA_NOM { get; set; } = null!;

    public string WPA_RUT { get; set; } = null!;

    public string WPA_EST { get; set; } = null!;

    public string WPA_TOPVER { get; set; } = null!;

    public int WPA_TOPORD { get; set; }

    public string WPA_BOTVER { get; set; } = null!;

    public int WPA_BOTORD { get; set; }

    public string WPA_OBS { get; set; } = null!;

    public string? WPA_TAG { get; set; }

    public DateTime? WPA_FUE { get; set; }

    public string WPA_REG { get; set; } = null!;

    public string WPA_LCK { get; set; } = null!;

    public DateTime? WPA_UPD { get; set; }

    public DateTime WPA_FAL { get; set; }

    public string WPA_TIP { get; set; } = null!;

    public string WPA_NOD { get; set; } = null!;

    public string WPA_CLA { get; set; } = null!;

    public string WPA_IDAPP { get; set; } = null!;
}
