using System;
using System.Collections.Generic;

namespace g2cloud.Web.Infrastructure.GestFact.DAL;

public partial class WDATA
{
    public string COD_WDA { get; set; } = null!;

    public string COD_WSI { get; set; } = null!;

    public string COD_WPA { get; set; } = null!;

    public string COD_WSE { get; set; } = null!;

    public int WDA_ORD { get; set; }

    public string WDA_EST { get; set; } = null!;

    public string WDA_OBS { get; set; } = null!;

    public string? WDA_TAG { get; set; }

    public DateTime? WDA_FUE { get; set; }

    public string WDA_REG { get; set; } = null!;

    public string WDA_LCK { get; set; } = null!;

    public DateTime? WDA_UPD { get; set; }

    public DateTime WDA_FAL { get; set; }
}
